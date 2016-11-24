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
        List<Baan> banen = new List<Baan>();
        List<Schutter> schutters = new List<Schutter>();
        public string Naam { get; set; }
        public Soort Soort { get; set; }
        public DateTime Datum { get; set; }

        public Wedstrijd(string naam, Soort soort, DateTime datum)
        {
            Naam = naam;
            Soort = soort;
            Datum = datum;
            aantalBanenBepalen();
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
            foreach (Schutter schutter in schutters)
            {
                //check of de schutter die wordt aangemeld, niet al is aangemeld.
                int schuttercheck = schutter.compareSchutters(nieuweSchutter);
                if (schuttercheck == 0)
                {
                    schutters.Add(nieuweSchutter);
                    MessageBox.Show($"{nieuweSchutter.Naam} is aangemeld voor {this.Soort.ToString()}");
                }
                else if (schuttercheck == 1)
                {
                    new AlAangemeldException(nieuweSchutter);
                }
            }
        }
        public void testSchutters()
        {
            //testdata schutters
            schutters.Add(new Schutter("Jelle Schraeder", Klasse.Senior, Discipline.Recurve, Geslacht.Heren));
            schutters.Add(new Schutter("Florentina Schwanen", Klasse.Junior, Discipline.Compound, Geslacht.Dames));
            schutters.Add(new Schutter("Stijn Koijen", Klasse.Senior, Discipline.Compound, Geslacht.Heren));
            schutters.Add(new Schutter("Mark van Broekhoven", Klasse.Cadet, Discipline.Recurve, Geslacht.Heren));
            schutters.Add(new Schutter("Ad van Vught", Klasse.Veteraan, Discipline.Barebow, Geslacht.Heren));
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
        private void banenAanmaken(int aantalBanen)
        {
            for (int baannr = 1; baannr <= aantalBanen; baannr++)
            {
                banen.Add(new Baan(baannr, "A"));
                //hier moet nog wat komen dat A, B, C en D automatisch ophoogt
            }
        }
        public override string ToString()
        {
            return $"Naam: {Naam}, datum: {Datum}, Soort: {Soort} Aantal schutters: {schutters.Count}";
        }
    }
}
