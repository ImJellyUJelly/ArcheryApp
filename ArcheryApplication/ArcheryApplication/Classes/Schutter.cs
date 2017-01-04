using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheryApplication.Classes.Enums;

namespace ArcheryApplication.Classes
{
    public class Schutter
    {
        public int Bondsnummer { get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public Baan Baan { get; set; }
        public Klasse Klasse { get; set; }
        public Discipline Discipline { get; set; }
        public Geslacht Geslacht { get; set; }
        public string Opmerking { get; set; }

        public Schutter(int bondsnr, string naam, Klasse k, Discipline d, Geslacht g, DateTime geb, string opmerking)
        {
            Bondsnummer = bondsnr;
            Naam = naam;
            Klasse = k;
            Discipline = d;
            Geslacht = g;
            Geboortedatum = geb;
            Opmerking = opmerking;
        }

        public void editSchutter(string naam, Klasse k, Discipline d, Geslacht g, DateTime geb, string opmerking)
        {
            Naam = naam;
            Klasse = k;
            Discipline = d;
            Geslacht = g;
            Geboortedatum = geb;
            Opmerking = opmerking;
        }

        public int compareSchutters(Schutter andereSchutter)
        {
            if (this.Naam.CompareTo(andereSchutter.Naam) == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"{Bondsnummer} { Naam }, Klasse: { Klasse }, Geslacht: { Geslacht } Discipline: { Discipline }, Geb.Datum: { Geboortedatum.ToShortDateString() }";
        }
    }
}
