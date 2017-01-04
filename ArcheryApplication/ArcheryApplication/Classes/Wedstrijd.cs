using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheryApplication.Classes;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Exceptions;
using System.Windows.Forms;

namespace ArcheryApplication.Classes
{
    public class Wedstrijd
    {
        Database db = new Database();
        List<Baan> banen = new List<Baan>();
        List<Schutter> schutters = new List<Schutter>();
        public int ID { get; set; }
        public string Naam { get; set; }
        public Soort Soort { get; set; }
        public string Datum { get; set; }

        public Wedstrijd(int id, string naam, Soort soort, string datum)
        {
            ID = id;
            Naam = naam;
            Soort = soort;
            Datum = datum;
            aantalBanenBepalen();
            testSchutters();
            schuttersaanbaantoevoegen();

            //banen = db.GetBanen();
            //schutters = db.GetSchutters();

        }
        public Wedstrijd(string naam, Soort soort, string datum)
        {
            Naam = naam;
            Soort = soort;
            Datum = datum;
            aantalBanenBepalen();
            testSchutters();
            schuttersaanbaantoevoegen();

            //banen = db.GetBanen();
            //schutters = db.GetSchutters();
        }

        //edit stuff
        public void veranderNaam(string naam)
        {
            Naam = naam;
        }
        public void veranderSoort(Soort soort)
        {
            Soort = soort;
        }

        public void schutterAanmelden(Schutter nieuweSchutter)
        {
            //de schuttercheck moet worden gefixt, deze werkt niet (schutter wordt altijd afgeslagen)
            //foreach (Schutter schutter in schutters)
            //{
            //check of de schutter die wordt aangemeld, niet al is aangemeld.
            //int schuttercheck = schutter.compareSchutters(nieuweSchutter);
            //if (schuttercheck == 0)
            //{
            schutters.Add(nieuweSchutter);
            MessageBox.Show($"{nieuweSchutter.Naam} is aangemeld voor {this.Soort.ToString()}");
            schuttersaanbaantoevoegen();
            //}
            //else if (schuttercheck == 1)
            //{
            //    new AlAangemeldException(nieuweSchutter);
            //}
            //}
        }
        public void testSchutters()
        {
            //testdata schutters
            schutters.Add(new Schutter(161378, "Jelle Schraeder", Klasse.Senior, Discipline.Recurve, Geslacht.Heren, DateTime.Now, ""));
            schutters.Add(new Schutter(111111, "Florentina Schwanen", Klasse.Junior, Discipline.Compound, Geslacht.Dames, DateTime.Now, ""));
            schutters.Add(new Schutter(222222, "Stijn Koijen", Klasse.Senior, Discipline.Compound, Geslacht.Heren, DateTime.Now, ""));
            schutters.Add(new Schutter(333333, "Mark van Broekhoven", Klasse.Cadet, Discipline.Recurve, Geslacht.Heren, DateTime.Now, ""));
            schutters.Add(new Schutter(444444, "Ad van Vught", Klasse.Veteraan, Discipline.Barebow, Geslacht.Heren, DateTime.Now, ""));
        }

        private void aantalBanenBepalen()
        {
            int banen;
            if (Soort == Soort.WA1440)
            {
                banen = 18;
                banenAanmaken(banen);
            }
            else if (Soort == Soort.JeugdFITA)
            {
                banen = 18;
                banenAanmaken(banen);
            }
            else if (Soort == Soort.Indoorcompetitie)
            {
                banen = 10;
                banenAanmaken(banen);
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

        public List<Schutter> getSchutters()
        {
            return schutters;
        }
        public List<Baan> getBanen()
        {
            return banen;
        }
        public void schuttersaanbaantoevoegen()
        {
            if (schutters != null)
            {
                foreach (Schutter S in schutters)
                {
                    if (S.Baan == null)
                    {
                        foreach (Baan B in banen)
                        {
                            if (B.Schutter == null)
                            {
                                B.VoegSchutterToe(S);
                                S.Baan = B;
                            }
                            if (S.Baan != null)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void banenAanmaken(int aantalBanen)
        {
            for (int baannr = 1; baannr <= aantalBanen; baannr++)
            {
                int letter = 0;
                for (int i = 0; i < 4; i++)
                {

                    if (letter == 0)
                    {
                        banen.Add(new Baan(baannr, "A", 70));
                        letter++;
                    }
                    else if (letter == 1)
                    {
                        banen.Add(new Baan(baannr, "B", 70));
                        letter++;
                    }
                    else if (letter == 2)
                    {
                        banen.Add(new Baan(baannr, "C", 70));
                        letter++;
                    }
                    else if (letter == 3)
                    {
                        banen.Add(new Baan(baannr, "D", 70));
                        letter = 0;
                    }
                }
            }
        }
        public override string ToString()
        {
            return $"Naam: {Naam}, datum: {Datum}, Soort: {Soort} Aantal schutters: {schutters.Count}";
        }
    }
}
