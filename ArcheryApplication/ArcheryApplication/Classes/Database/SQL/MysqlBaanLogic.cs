using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using ArcheryApplication.Classes.Database.Interfaces;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Exceptions;

namespace ArcheryApplication.Classes.Database.SQL
{
    public class MysqlBaanLogic : IBaanServices
    {
        // https://www.connectionstrings.com/sql-server/
        private readonly string _connectie = @"Server=(localdb)\Archery;Integrated Security=true;";

        public List<Baan> ListBanen(int wedId)
        {
            List<Baan> banen = new List<Baan>();
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
                                cmd.CommandText = "SELECT BaanInd.BaanId, BaanInd.BaanNr, BaanInd.BaanLetter, BaanInd.BaanVerNr FROM BaanIndeling BaanInd";
                                cmd.Connection = conn;


                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        int id = reader.GetInt32(0);
                                        string naam;
                                        // Volgens mij hoeft dit niet eens, naam is namelijk verplicht.
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

                                        // Vereniging
                                        int vernr = reader.GetInt32(4);
                                        string vernaam = reader.GetString(5);
                                        string verstraat = reader.GetString(6);
                                        string verhuisnr = reader.GetString(7);
                                        string verpostcode = reader.GetString(8);
                                        string verstad = reader.GetString(9);

                                        Vereniging vereniging = new Vereniging(vernr, vernaam, verstraat, verhuisnr, verpostcode, verstad);

                                        //banen.Add(new Baan());
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
            catch (NormalException ex)
            {
                throw new NormalException(ex.Message);
            }
        }

        public Baan GetBaanById(int baanId)
        {
            throw new NotImplementedException();
        }

        public Baan GetBaanByNummer(int baanNummer)
        {
            throw new NotImplementedException();
        }

        public List<Schutter> ListSchuttersOpBaan(int baanId)
        {
            throw new NotImplementedException();
        }

        public void AddBaan(Baan baan)
        {
            throw new NotImplementedException();
        }

        public void EditBaan(Baan baan)
        {
            throw new NotImplementedException();
        }

        public void RemoveBaan(Baan baan)
        {
            throw new NotImplementedException();
        }

        public void AddSchutterTobaan(Schutter schutter, int baanId)
        {
            throw new NotImplementedException();
        }

        public void RemoveSchutterFromBaan(Schutter schutter, int baanId)
        {
            throw new NotImplementedException();
        }
    }
}
