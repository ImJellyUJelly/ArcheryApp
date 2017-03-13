using System;
using System.Collections.Generic;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Exceptions;
using System.Windows.Forms;

namespace ArcheryApplication.Classes
{
    public class Wedstrijd
    {
        List<Baan> _banen = new List<Baan>();
        List<Schutter> _schutters = new List<Schutter>();
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public Soort Soort { get; private set; }
        public string Datum { get; private set; }

        public Wedstrijd(int id, string naam, Soort soort, string datum)
        {
            Id = id;
            Naam = naam;
            Soort = soort;
            Datum = datum;
            AantalBanenBepalen();
            //testSchutters();
            //schuttersaanbaantoevoegen();

            //banen = db.GetBanen();
            //schutters = db.GetSchutters();

        }
        public Wedstrijd(string naam, Soort soort, string datum)
        {
            Naam = naam;
            Soort = soort;
            Datum = datum;
            AantalBanenBepalen();
            //testSchutters();
            //schuttersaanbaantoevoegen();

            //banen = db.GetBanen();
            //schutters = db.GetSchutters();
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
                MessageBox.Show($"Error: {nieuweSchutter.Naam} met bondsnummer {nieuweSchutter.Bondsnummer} is al aangemeld voor {Soort.ToString()}");
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
        public void TestSchutters()
        {
            //testdata schutters
            _schutters.Add(new Schutter(161378, "Jelle Schraeder", Klasse.Senior, Discipline.Recurve, Geslacht.Heren, DateTime.Now, ""));
            _schutters.Add(new Schutter(111111, "Florentina Schwanen", Klasse.Junior, Discipline.Compound, Geslacht.Dames, DateTime.Now, ""));
            _schutters.Add(new Schutter(222222, "Stijn Koijen", Klasse.Senior, Discipline.Compound, Geslacht.Heren, DateTime.Now, ""));
            _schutters.Add(new Schutter(333333, "Mark van Broekhoven", Klasse.Cadet, Discipline.Recurve, Geslacht.Heren, DateTime.Now, ""));
            _schutters.Add(new Schutter(444444, "Ad van Vught", Klasse.Veteraan, Discipline.Barebow, Geslacht.Heren, DateTime.Now, ""));
        }

        private bool SchutterCheck(int bondsnummer)
        {
            foreach (Schutter s in _schutters)
            {
                if (bondsnummer == s.Bondsnummer)
                {
                    throw new SchutterException("Schutter is al aangemeld voor deze wedstrijd.");
                }
            }
            return true;
        }

        private void AantalBanenBepalen()
        {
            int banen;
            if (Soort == Soort.Wa1440)
            {
                banen = 18;
                BanenAanmaken(banen);
            }
            else if (Soort == Soort.JeugdFita)
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
                MessageBox.Show("Kies een andere soort, wij organiseren geen veld.");
            }
            else
            {
                MessageBox.Show("Volgens mij gaat er wat mis, aantal banen is niet bepaald.");
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
                                s.GeefSchutterEenBaan(b);
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
            for (int baannr = 1; baannr <= aantalBanen; baannr++)
            {
                int letter = 0;
                for (int i = 0; i < 4; i++)
                {

                    if (letter == 0)
                    {
                        _banen.Add(new Baan(baannr, "A", 70));
                        letter++;
                    }
                    else if (letter == 1)
                    {
                        _banen.Add(new Baan(baannr, "B", 70));
                        letter++;
                    }
                    else if (letter == 2)
                    {
                        _banen.Add(new Baan(baannr, "C", 70));
                        letter++;
                    }
                    else if (letter == 3)
                    {
                        _banen.Add(new Baan(baannr, "D", 70));
                        letter = 0;
                    }
                }
            }
        }
        public override string ToString()
        {
            return $"Naam: {Naam}, datum: {Datum}, Soort: {Soort} Aantal schutters: {_schutters.Count}";
        }
    }
}
