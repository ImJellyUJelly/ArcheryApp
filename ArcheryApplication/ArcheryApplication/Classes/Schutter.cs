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
        public Klasse Klasse { get; set; }
        public Discipline Discipline { get; set; }
        public Geslacht Geslacht { get; set; }

        public Schutter(string n, Klasse k, Discipline d, Geslacht g)
        {
            Naam = n;
            Baan = new Classes.Baan(1, "A");
            Klasse = k;
            Discipline = d;
            Geslacht = g;
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
            return $"{Naam}, Klasse: {Klasse}, Discipline: {Discipline}";
        }
    }
}
