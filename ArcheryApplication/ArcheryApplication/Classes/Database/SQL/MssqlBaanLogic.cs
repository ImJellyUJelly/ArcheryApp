using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheryApplication.Classes.Database.Interfaces;

namespace ArcheryApplication.Classes.Database.SQL
{
    public class MssqlBaanLogic : IBaanServices
    {
        private readonly string connectie = "";
        public void AddBaan(Baan baan)
        {
            using (SqlConnection conn = new SqlConnection(connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "INSERT INTO Baan (Nummer, Letter, Afstand) VALUES (@nummer, @letter, @afstand);";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@nummer", baan.Baannummer);
                            cmd.Parameters.AddWithValue("@letter", baan.Letter);
                            cmd.Parameters.AddWithValue("@afstand", baan.Afstand);

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

        public void AddSchutterTobaan(Schutter schutter, int baanId)
        {
            throw new NotImplementedException();
        }

        public void EditBaan(Baan baan)
        {
            using (SqlConnection conn = new SqlConnection(connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "UPDATE Baan SET Nummer = @nummer, Letter = @letter, Afstand = @afstand WHERE ID = @baanId;";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@baanId", baan.BaanId);
                            cmd.Parameters.AddWithValue("@nummer", baan.Baannummer);
                            cmd.Parameters.AddWithValue("@letter", baan.Letter);
                            cmd.Parameters.AddWithValue("@afstand", baan.Afstand);

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

        public Baan GetBaanByID(int baanId)
        {
            using (SqlConnection conn = new SqlConnection(connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "SELECT ID, Nummer, Letter, Afstand FROM Baan WHERE ID = @baanId";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@baanId", baanId);

                            using(SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int id = reader.GetInt32(0);
                                    int nummer = reader.GetInt32(1);
                                    string letter = reader.GetString(2);
                                    int afstand = reader.GetInt32(3);

                                    return new Baan(id, nummer, letter, afstand);
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
            return null;
        }

        public Baan GetBaanByNummer(int baanNummer)
        {
            using (SqlConnection conn = new SqlConnection(connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "SELECT ID, Nummer, Letter, Afstand FROM Baan WHERE Nummer = @nummer";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@nummer", baanNummer);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int id = reader.GetInt32(0);
                                    int nummer = reader.GetInt32(1);
                                    string letter = reader.GetString(2);
                                    int afstand = reader.GetInt32(3);

                                    return new Baan(id, nummer, letter, afstand);
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
            return null;
        }

        public List<Baan> ListBanen()
        {
            List<Baan> banen = new List<Baan>();
            using (SqlConnection conn = new SqlConnection(connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "SELECT ID, Nummer, Letter, Afstand FROM Baan;";
                            cmd.Connection = conn;


                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int id = reader.GetInt32(0);
                                    int nummer = reader.GetInt32(1);
                                    string letter = reader.GetString(2);
                                    int afstand = reader.GetInt32(3);

                                    banen.Add(new Baan(id, nummer, letter, afstand));
                                }
                                return banen;
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

        public List<Schutter> ListSchuttersOpBaan(int baanId)
        {
            List<Schutter> schutters = new List<Schutter>();
            using (SqlConnection conn = new SqlConnection(connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "SELECT S.ID, S.Bondsnummer, S.Naam, S.Emailadres, S.Geboortedatum, S.Opmerking, D.Naam, K.Naam, G.Naam, V.Nr, V.Naam, V.Straatnaam, V.Huisnummer, V.Postcode, V.Stad FROM Schutter S " +
                                "LEFT JOIN SchutterOpBaan SOB ON SOB.SchutterID = S.ID " +
                                "LEFT JOIN Baan B ON B.ID = SOB.BaanID " +
                                "LEFT JOIN Discipline D ON D.ID = S.DisciplineID" +
                                "LEFT JOIN Klasse K ON K.ID = S.KlasseID" +
                                "LEFT JOIN Vereniging V ON V.Nr = S.VerenigingNr" +
                                "WHERE B.ID = @baanId;";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@baanId", baanId);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int id = reader.GetInt32(0);
                                    int bondsnr;
                                    if (!reader.IsDBNull(1))
                                    {
                                        bondsnr = reader.GetInt32(1);
                                    }
                                    else
                                    {
                                        bondsnr = 0;
                                    }
                                    string naam = reader.GetString(2);
                                    string email = reader.GetString(3);
                                    DateTime gebdatum;
                                    if (!reader.IsDBNull(4))
                                    {
                                        gebdatum = DateTime.Parse(reader.GetString(4));
                                    }
                                    else
                                    {
                                        gebdatum = DateTime.Parse("01/01/2000");
                                    }
                                    string opmerking;
                                    if (!reader.IsDBNull(5))
                                    {
                                        opmerking = reader.GetString(5);
                                    }
                                    else
                                    {
                                        opmerking = "Geen opmerking opgegeven.";
                                    }
                                    Discipline discipline = (Discipline)Enum.Parse(typeof(Discipline), reader.GetString(6));
                                    Klasse klasse = (Klasse)Enum.Parse(typeof(Klasse), reader.GetString(7));
                                    Geslacht geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), reader.GetString(8));
                                    Vereniging vereniging = new Vereniging(reader.GetInt32(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14));

                                    schutters.Add(new Schutter(id, bondsnr, naam, klasse, discipline, geslacht, gebdatum, opmerking, vereniging));
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

        public void RemoveBaan(Baan baan)
        {
            using (SqlConnection conn = new SqlConnection(connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "DELETE FROM Baan WHERE ID = @baanId;";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@baanId", baan.BaanId);

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

        public void RemoveSchutterFromBaan(Schutter schutter, int baanId)
        {
            using (SqlConnection conn = new SqlConnection(connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "DELETE FROM SchutterOpBaan WHERE SchutterID = @schutterId AND BaanID = @baanId;";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@schutterId", schutter.ID);
                            cmd.Parameters.AddWithValue("@baanId", baanId);

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
    }
}
