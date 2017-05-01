using System;
using System.Collections.Generic;
using System.Data;
using ArcheryApplication.Classes.Database.Interfaces;
using ArcheryApplication.Exceptions;
using MySql.Data.MySqlClient;

namespace ArcheryApplication.Classes.Database.SQL
{
    public class MysqlSchutterLogic : ISchutterServices
    {
        private const string _connectie =
            "Server = studmysql01.fhict.local;Uid=dbi299244;Database=dbi299244;Pwd=Geschiedenis1500;";
        private MysqlWedstrijdLogic wedstrijdLogic = new MysqlWedstrijdLogic();
        public Schutter GetSchutterById(int schutterId)
        {
            throw new NotImplementedException();
        }

        public Schutter GetSchutterByBondsNr(int bondsnr)
        {
            throw new NotImplementedException();
        }

        public List<Schutter> ListSchutters()
        {
            try
            {
                List<Schutter> schutters = new List<Schutter>();
                using (MySqlConnection conn = new MySqlConnection(_connectie))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            try
                            {
                                cmd.CommandText =
                                        "SELECT SchutID, SchutBondsNr, SchutNaam, RegDiscipline, SchutGeslacht, SchutEmail, SchutGebDatum, SchutOpmerking, KlasseNaam, SchutVerNr" +
                                        "FROM Schutter S" +
                                        "LEFT JOIN Registratie R ON R.RegSchutterID = S.SchutID" +
                                        "LEFT JOIN Wedstrijd W ON W.WedID = R.RegWedID" +
                                        "LEFT JOIN BaanIndeling BI ON BI.BaIndelWedID = W.WedID" +
                                        "LEFT JOIN Baan B ON B.BaanID = BI.BaIndelBaanID" +
                                        "LEFT JOIN Klasse K ON K.KlasseID = S.SchutKlasseID" +
                                        "LEFT JOIN Vereniging V ON V.VerNr = S.SchutVerNr;";
                                cmd.Connection = conn;


                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        int schutterId = reader.GetInt32(0);
                                        int bondsnummer = reader.GetInt32(1);
                                        string naam = reader.GetString(2);
                                        Discipline discipline = (Discipline) Enum.Parse(typeof(Discipline), reader.GetString(3));
                                        string geslacht = reader.GetString(4);
                                        if (geslacht == "H")
                                        {
                                            geslacht = "Heren";
                                        }
                                        if (geslacht == "D")
                                        {
                                            geslacht = "Dames";
                                        }
                                        string email = reader.GetString(5);
                                        DateTime gebdatum = DateTime.Parse(reader.GetString(6));
                                        string opmerking = reader.GetString(7);
                                        Klasse klasse = (Klasse) Enum.Parse(typeof(Klasse), reader.GetString(8));

                                        Vereniging vereniging = wedstrijdLogic.GetVerenigingById(reader.GetInt32(9));

                                        schutters.Add(new Schutter(schutterId, bondsnummer, naam, email, klasse, discipline, geslacht, gebdatum, opmerking, vereniging));
                                    }
                                    return schutters;
                                }
                            }
                            catch (Exception ex)
                            {
                                throw new DataException(ex.Message);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                }
                return null;
            }
            catch (NormalException ex)
            {
                throw new NormalException(ex.Message);
            }
        }

        public void AddSchutter(Schutter schutter)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectie))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            try
                            {
                                cmd.CommandText =
                                    "INSERT INTO Schutter (SchutBondsNr, SchutNaam, SchutGeslacht, SchutEmail, SchutGebDatum, SchutOpmerking, SchutKlasseID, SchutVerNr) " +
                                    "VALUES(@bondsnr, @naam, @geslacht, @email, @geboortedatum, @opmerking, @klasseId, @verNr);";

                                cmd.Parameters.AddWithValue("@bondsnr", schutter.Bondsnummer);
                                cmd.Parameters.AddWithValue("@naam", schutter.Naam);
                                cmd.Parameters.AddWithValue("@geslacht", schutter.Geslacht);
                                cmd.Parameters.AddWithValue("@email", schutter.EmailAdres);
                                cmd.Parameters.AddWithValue("@geboortedatum", schutter.Geboortedatum);
                                cmd.Parameters.AddWithValue("@opmerking", schutter.Opmerking);
                                cmd.Parameters.AddWithValue("@klasseId", GetKlasseId(schutter.Klasse.ToString()));
                                cmd.Parameters.AddWithValue("@verNr", schutter.EmailAdres);

                                cmd.Connection = conn;
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                throw new DataException(ex.Message);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                }
            }
            catch (NormalException ex)
            {
                throw new NormalException(ex.Message);
            }
        }

        public void EditSchutter(Schutter schutter)
        {
            throw new NotImplementedException();
        }

        public void RemoveSchutter(Schutter schutter)
        {
            throw new NotImplementedException();
        }

        private int GetKlasseId(string klasseNaam)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "SELECT KlasseId FROM Klasse WHERE KlasseNaam = @klasseNaam;";

                            cmd.Parameters.AddWithValue("@klasseNaam", klasseNaam);
                            cmd.Connection = conn;

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int klasseId = reader.GetInt32(0);

                                    return klasseId;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new DataException(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
            return 0;
        }
    }
}

