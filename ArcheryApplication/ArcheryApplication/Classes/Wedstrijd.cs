using System;
using System.Collections.Generic;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Exceptions;
using System.Windows.Forms;
using ArcheryApplication.Classes.Database.Repositories;
using ArcheryApplication.Classes.Database.SQL;

namespace ArcheryApplication.Classes
{
    public class Wedstrijd
    {
        private WedstrijdRepository wedstrijdrepo = new WedstrijdRepository(new MysqlWedstrijdLogic());
        private BaanRepository banenrepo = new BaanRepository(new MysqlBaanLogic());
        List<Baan> _banen = new List<Baan>();
        List<Schutter> _schutters = new List<Schutter>();
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public Soort Soort { get; private set; }
        public string Datum { get; private set; }
        public Vereniging Vereniging { get; private set; }
        public Wedstrijd(int id, string naam, Soort soort, string datum, Vereniging vereniging)
        {
            Id = id;
            Naam = naam;
            Soort = soort;
            Datum = datum;
            Vereniging = vereniging;
            LaadBanen();
        }
        public Wedstrijd(string naam, Soort soort, string datum)
        {
            Naam = naam;
            Soort = soort;
            Datum = datum;
            LaadBanen();
        }

        //edit stuff
        public void BewerkWedstrijd(string naam, Soort soort, string datum)
        {
            Naam = naam;
            Soort = soort;
            Datum = datum;
        }

        public void SchutterAanmelden(Schutter nieuweSchutter)
        {
            if (SchutterCheck(nieuweSchutter.Bondsnummer))
            {
                _schutters.Add(nieuweSchutter);
                MessageBox.Show(string.Format("Gelukt! {0} is aangemeld voor {1}", nieuweSchutter.Naam, Naam));
                if (nieuweSchutter.Baan == null)
                {
                    Schuttersaanbaantoevoegen();
                }
            }
            else
            {
                MessageBox.Show(string.Format("Error: {0} met bondsnummer {1} is al aangemeld voor {2}",
                    nieuweSchutter.Naam, nieuweSchutter.Bondsnummer, Soort.ToString()));
            }
        }
        public void SchutterAanmeldenOpBaan(Schutter nieuweSchutter)
        {
            SchutterAanmelden(nieuweSchutter);
            foreach (Baan b in _banen)
            {
                if (b.BaanId == nieuweSchutter.Baan.BaanId)
                {
                    b.VoegSchutterToe(nieuweSchutter);
                }
            }
        }

        private bool SchutterCheck(int bondsnummer)
        {
            foreach (Schutter s in _schutters)
            {
                if (bondsnummer == s.Bondsnummer)
                {
                    if (bondsnummer != -1)
                    {
                        throw new SchutterException("Schutter is al aangemeld voor deze wedstrijd.");
                    }
                }
            }
            return true;
        }

        private void LaadBanen()
        {
            try
            {
                List<Baan> banenUitDb = wedstrijdrepo.WedstrijdBanen(this);
                if (banenUitDb != null)
                {
                    _banen = banenUitDb;
                }
                else
                {
                    AantalBanenBepalen();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AantalBanenBepalen()
        {
            int banen;
            if (Soort == Soort.WA1440)
            {
                banen = 18;
                BanenAanmaken(banen);
            }
            else if (Soort == Soort.JeugdFITA)
            {
                banen = 18;
                BanenAanmaken(banen);
            }
            else if (Soort == Soort.Indoorcompetitie)
            {
                banen = 10;
                BanenAanmaken(banen);
            }
            else if (Soort == Soort.Veld)
            {
                MessageBox.Show(@"Kies een andere soort, wij organiseren geen veld.");
            }
            else if (Soort == Soort.Face2Face)
            {
                banen = 19;
                BanenAanmaken(banen);
            }
            else

            {
                MessageBox.Show(@"Volgens mij gaat er wat mis, aantal banen is niet bepaald.");
            }
        }

        public List<Schutter> GetSchutters()
        {
            return _schutters;
        }
        public List<Baan> GetBanen()
        {
            return _banen;
        }
        // Als de schutter geen baan heeft geselecteerd
        public void Schuttersaanbaantoevoegen()
        {
            if (_schutters != null)
            {
                foreach (Schutter s in _schutters)
                {
                    if (s.Baan == null)
                    {
                        foreach (Baan b in _banen)
                        {
                            if (b.Schutter == null)
                            {
                                b.VoegSchutterToe(s);
                            }
                            if (s.Baan != null)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void BanenAanmaken(int aantalBanen)
        {
            List<Baan> banen = banenrepo.ListBanen(Id);
            for (int baannr = 1; baannr <= aantalBanen; baannr++)
            {
                int letter = 0;
                Baan baan;
                for (int i = 0; i < 4; i++)
                {
                    try
                    {
                        if (letter == 0)
                        {
                            baan = banen[baannr];
                            baan.Afstand = 70;
                            wedstrijdrepo.AddBaanToWedstrijd(baan, Id);
                            _banen.Add(baan);
                            letter++;
                        }
                        else if (letter == 1)
                        {
                            baan = banen[baannr];
                            baan.Afstand = 70;
                            wedstrijdrepo.AddBaanToWedstrijd(baan, Id);
                            _banen.Add(baan);
                            letter++;
                        }
                        else if (letter == 2)
                        {
                            baan = banen[baannr];
                            baan.Afstand = 70;
                            wedstrijdrepo.AddBaanToWedstrijd(baan, Id);
                            _banen.Add(baan);
                            letter++;
                        }
                        else if (letter == 3)
                        {
                            baan = banen[baannr];
                            baan.Afstand = 70;
                            wedstrijdrepo.AddBaanToWedstrijd(baan, Id);
                            _banen.Add(baan);
                            letter = 0;
                        }
                    }
                    catch (Exception exception)
                    {
                        throw new Exception(exception.Message);
                    }
                }
            }
        }
        public override string ToString()
        {
            return $"{Naam} - datum: {Datum} - Soort: {Soort} - Aantal schutters: {_schutters.Count}";
        }
    }
}
