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
        public List<Schutter> Schutters { get; set; }
        public int Afstand { get; set; }

        public Baan(int baanNummer, int afstand)
        {
            Baannummer = baanNummer;
            Letters = new List<Letter>() { new Letter("A"), new Letter("B"), new Letter("C"), new Letter("D") };
            Afstand = afstand;
        }

        public void voegSchutterAanLetter(Schutter schutter)
        {
            foreach (Letter L in Letters)
            {
                if (schutter.Letter == null)
                {
                    L.Schutter = schutter;
                    schutter.Letter = L;
                    schutter.Baan = this;
                }
                if (schutter.Letter != null)
                {
                    break;
                }
            }
        }
        public List<Schutter> schutters()
        {
            List<Schutter> schuttersOpLetter = new List<Schutter>();
            foreach (Schutter S in Schutters)
            {
                schuttersOpLetter.Add(S);
            }
            return schuttersOpLetter;
        }
        public override string ToString()
        {
            return $"{Baannummer}";
        }
    }
}
