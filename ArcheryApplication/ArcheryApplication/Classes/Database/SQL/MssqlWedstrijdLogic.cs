using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheryApplication.Classes.Database.Interfaces;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Exceptions;

namespace ArcheryApplication.Classes.Database.SQL
{
    public class MssqlWedstrijdLogic : IWedstrijdServices
    {
        private readonly string connectie = @"Data Source=.;Initial Catalog = Archery; Integrated Security = True;";

        public void AddBaanToWedstrijd(Baan baan, int wedstrijdId)
        {
            throw new NotImplementedException();
        }

        public void AddWedstrijd(Wedstrijd wedstrijd)
        {
            throw new NotImplementedException();
        }

        public void EditBaanFromWedstrijd(Baan baan, int wedstrijdId)
        {
            throw new NotImplementedException();
        }

        public void EditWedstrijd(Wedstrijd wedstrijd)
        {
            throw new NotImplementedException();
        }

        public Wedstrijd GetWedstrijdByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Wedstrijd GetWedstrijdById(int wedstrijdId)
        {
            throw new NotImplementedException();
        }

        public List<Wedstrijd> ListWedstrijden()
        {
            try
            {
                List<Wedstrijd> wedstrijden = new List<Wedstrijd>();
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
                                    "SELECT ID, Naam, Soort, Datum, VerenigingNr FROM Vereniging;";
                                cmd.Connection = conn;


                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        int id = reader.GetInt32(0);
                                        string naam;
                                        if (!reader.IsDBNull(1))
                                        {
                                            naam = reader.GetString(1);
                                        }
                                        else
                                        {
                                            naam = "Geen naam";
                                        }
                                        Soort soort = (Soort)Enum.Parse(typeof(Soort), reader.GetString(2));
                                        string datum = reader.GetString(3);

                                        wedstrijden.Add(new Wedstrijd(id, naam, soort, datum));
                                    }
                                    return wedstrijden;
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

        public void RemoveBaanFromWedstrijd(Baan baan, int wedstrijdId)
        {
            throw new NotImplementedException();
        }

        public void RemoveWedstrijd(Wedstrijd wedstrijd)
        {
            throw new NotImplementedException();
        }

        public List<Baan> WedstrijdBanen(int wedstrijdId)
        {
            throw new NotImplementedException();
        }
    }
}
