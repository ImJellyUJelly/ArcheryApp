//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ArcheryApplication.Classes.Enums;

//namespace ArcheryApplication.Classes
//{
//    public class Database2
//    {
//        public List<Wedstrijd> GetWedstrijden()
//        {
//            List<Wedstrijd> wedstrijden = new List<Wedstrijd>();
//            using (SqlConnection conn = new SqlConnection(connectie))
//            {
//                if (conn.State != ConnectionState.Open)
//                {
//                    conn.Open();

//                    try
//                    {
//                        using (SqlCommand cmd = new SqlCommand())
//                        {
//                            cmd.CommandText = "SELECT ID, Naam, Soort, Datum FROM Wedstrijd";
//                            cmd.Connection = conn;

//                            using (SqlDataReader reader = cmd.ExecuteReader())
//                            {
//                                while (reader.Read())
//                                {
//                                    int ID = reader.GetInt32(0);
//                                    string naam = reader.GetString(1);
//                                    Soort soort = (Soort)Enum.Parse(typeof(Soort), reader.GetString(2));
//                                    string datum = reader.GetString(3);

//                                    wedstrijden.Add(new Wedstrijd(ID, naam, soort, datum));
//                                }
//                                return wedstrijden;
//                            }

//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        throw new Exceptions.NormalException(ex.Message);
//                    }
//                    finally
//                    {
//                        conn.Close();
//                    }
//                }
//            }
//            return null;
//        }

//        public List<Schutter> GetSchutters()
//        {
//            List<Schutter> schutters = new List<Schutter>();
//            using (SqlConnection conn = new SqlConnection(connectie))
//            {
//                if (conn.State != ConnectionState.Open)
//                {
//                    conn.Open();

//                    try
//                    {
//                        using (SqlCommand cmd = new SqlCommand())
//                        {
//                            cmd.CommandText = "SELECT Bondsnummer, Naam, Geboortedatum, Klasse, Discipline, Geslacht, Opmerking FROM Schutter";
//                            cmd.Connection = conn;

//                            using (SqlDataReader reader = cmd.ExecuteReader())
//                            {
//                                while (reader.Read())
//                                {
//                                    int bnr = reader.GetInt32(0);
//                                    string naam = reader.GetString(1);
//                                    DateTime gebdat = reader.GetDateTime(2);
//                                    Klasse klasse = (Klasse)Enum.Parse(typeof(Klasse), reader.GetString(3));
//                                    Discipline discipline = (Discipline)Enum.Parse(typeof(Discipline), reader.GetString(4));
//                                    Geslacht geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), reader.GetString(5));
//                                    string opmerking = reader.GetString(6);

//                                    schutters.Add(new Schutter(bnr, naam, klasse, discipline, geslacht, gebdat, opmerking));
//                                }
//                                return schutters;
//                            }

//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        throw new Exceptions.NormalException(ex.Message);
//                    }
//                    finally
//                    {
//                        conn.Close();
//                    }
//                }
//            }
//            return null;
//        }
//    }
//}
