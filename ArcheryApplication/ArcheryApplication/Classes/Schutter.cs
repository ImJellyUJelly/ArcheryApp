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
        //public void verhoogScore(int p1, int p2, int p3, int p4, int p5, int p6)
        //{
        //    if (p6 == -1 && p5 == -1 && p4 == -1)
        //    {
        //        //3 pijlen geschoten
        //        TotaalScore.VerhoogScore(p1 + p2 + p3);
        //    }
        //    else if (p6 == -1 && p5 == -1 && p4 == -1 && p3 == -1 && p2 == -1)
        //    {
        //        //1 pijl geschoten
        //        TotaalScore.VerhoogScore(p1);
        //    }
        //    else
        //    {
        //        //6 pijlen geschoten
        //        TotaalScore.VerhoogScore(p1, p2, p3, p4, p5, p6);
        //    }
        //}
        public override string ToString()
        {
            return $"{ Naam }, Klasse: { Klasse }, Geslacht: { Geslacht } Discipline: { Discipline }, Geb.Datum: { Geboortedatum.ToShortDateString() }";
        }
    }
}
