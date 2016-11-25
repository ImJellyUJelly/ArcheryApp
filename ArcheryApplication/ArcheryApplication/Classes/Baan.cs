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
            Letters = new List<Letter>();
            voegLettersToe();
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
            for (int i = 0; i <= 3; i++)
            {
                if (Schutter == null)
                {
                    Schutter = schutter;
                }
            }
        }
        private void voegLettersToe()
        {
            Letters.Add(new Letter("A"));
            Letters.Add(new Letter("B"));
            Letters.Add(new Letter("C"));
            Letters.Add(new Letter("D"));
        }
        public override string ToString()
        {
            return $"{Baannummer}{Letters[Letter]}";
        }
    }
}
