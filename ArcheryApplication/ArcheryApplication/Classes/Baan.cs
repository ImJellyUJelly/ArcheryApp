using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheryApplication.Classes.Enums;

namespace ArcheryApplication.Classes
{
    public class Baan
    {

        public int Baannummer { get; set; }
        public List<Letter> Letters { get; set; }
        public Schutter Schutter { get; set; }
        public int Afstand { get; set; }

        public Baan(int baanNummer, int afstand)
        {
            Letters = new List<Letter>() { new Letter("A", this), new Letter("B", this), new Letter("C", this), new Letter("D", this) };
            Baannummer = baanNummer;
            Schutter = null;
            Afstand = afstand;
        }
        //public Baan(int baanNummer, string letter, int afstand)
        //{
        //    Baannummer = baanNummer;
        //    Schutter = null;
        //    Afstand = afstand;
        //}
        public void voegSchutterAanLetter(Schutter schutter)
        {
            foreach (Letter L in Letters)
            {
                if (schutter.Baan == null)
                {
                    L.Schutter = schutter;
                    break;
                }
            }
        }

        private Letter returnletters()
        {
            Letter Le = null;
            foreach (Letter L in Letters)
            {
                Le = L;
            }
            return Le;
        }
        public override string ToString()
        {
            return $"{Baannummer}{returnletters()}";
        }
    }
}
