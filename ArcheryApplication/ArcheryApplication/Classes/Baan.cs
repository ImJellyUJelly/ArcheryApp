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
        public int Letter { get; set; }

        public Baan(int baanNummer, int letter, int afstand)
        {
            Letter = letter;
            Letters = new List<Letter>() { new Letter("A"), new Classes.Letter("B"), new Letter("C"), new Letter("D") }; //zoiets moet het worden
            //voegLettersToe(); 
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
        private void voegLettersToe()
        {//niet meer nodig
            Letters.Add(new Letter("A"));
            Letters.Add(new Letter("B"));
            Letters.Add(new Letter("C"));
            Letters.Add(new Letter("D"));
        }
        public override string ToString()
        {
            return $"{Baannummer}";
        }
    }
}
