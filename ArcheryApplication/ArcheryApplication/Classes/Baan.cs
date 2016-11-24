using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes
{
    public class Baan
    {
        public int Baannummer { get; set; }
        public string Letter { get; set; }
        public Schutter Schutter { get; set; }

        public Baan(int baanNummer, string letter)
        {
            Baannummer = baanNummer;
            Letter = letter;
            Schutter = null;
        }
        public void voegSchutterAanBaan(Schutter schutter)
        {
            Schutter = schutter;
        }
        public override string ToString()
        {
            return $"{Baannummer + Letter}";
        }
    }
}
