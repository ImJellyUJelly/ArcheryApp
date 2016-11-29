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
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public Score TotaalScore { get; set; }
        public Baan Baan { get; set; }
        public Letter Letter { get; set; }
        public Klasse Klasse { get; set; }
        public Discipline Discipline { get; set; }
        public Geslacht Geslacht { get; set; }
        public string Opmerking { get; set; }

        public Schutter(string naam, Klasse k, Discipline d, Geslacht g, string opmerking)
        {

            Naam = naam;
            Klasse = k;
            Discipline = d;
            Geslacht = g;
            Opmerking = opmerking;
        }

        public void editSchutter(string naam, Klasse k, Discipline d, Geslacht g, string opmerking)
        {

        }

        public int compareSchutters(Schutter andereSchutter)
        {
            if (this.Naam.CompareTo(andereSchutter.Naam) == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public override string ToString()
        {
            return $"{ Baan }{ Letter }: { Naam }, Klasse: { Klasse }, Discipline: { Discipline }";
        }
    }
}
