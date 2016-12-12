using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes
{
    public class Letter
    {
        public string _Letter { get; set; }
        public Schutter Schutter { get; set; }
        public Baan Baan { get; set; }
        public Letter(string letter, Baan baan)
        {
            Baan = baan;
            _Letter = letter;
            Schutter = null;
        }

        public void voegSchutterToe(Schutter schutter)
        {
            Schutter = schutter;
        }
        public override string ToString()
        {
            return $"{Baan}{_Letter}: {Schutter}";
        }
    }
}
