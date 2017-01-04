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
        public string ID { get; set; }
        public int Baannummer { get; set; }
        public string Letter { get; set; }
        public Schutter Schutter { get; private set; }
        public int Afstand { get; set; }

        public Baan(int baanNummer, string letter, int afstand)
        {
            Baannummer = baanNummer;
            Letter = letter;
            Afstand = afstand;
            ID = $"{Baannummer}{Letter}";
        }
        public void VoegSchutterToe(Schutter schutter)
        {
            if (Schutter == null)
            {
                Schutter = schutter;
            }
        }
        public override string ToString()
        {
            if (Schutter == null)
            {
                return $"{ Baannummer }{ Letter }: Geen schutter";
            }
            return $"{ Baannummer }{ Letter }: { Schutter.ToString() }";
        }
    }
}
