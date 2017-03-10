using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes
{
    public class Vereniging
    {
        private int VerNr { get; set; }
        private string Naam { get; set; }
        private string Straatnaam { get; set; }
        private string Huisnummer { get; set; }
        private string Postcode { get; set; }
        private string Plaats { get; set; }

        public Vereniging(int nr, string naam, string straat, string hnr, string postcode, string plaats)
        {
            VerNr = nr;
            Naam = naam;
            Straatnaam = straat;
            Huisnummer = hnr;
            Postcode = postcode;
            Plaats = plaats;
        }
        public Vereniging(int nr, string naam)
        {
            VerNr = nr;
            Naam = naam;
        }
        public Vereniging(string naam)
        {
            Naam = naam;
        }
        //change
        public bool ChangeNr(int nr)
        {
            VerNr = nr;
            return true;
        }
        public bool ChangeNaam(string naam)
        {
            Naam = naam;
            return true;
        }
        public bool ChangePlaats(string plaats)
        {
            Plaats = plaats;
            return true;
        }

        //get
        public int GetNr()
        {
            return VerNr;
        }
        public string GetNaam()
        {
            return Naam;
        }
        public string GetPlaats()
        {
            return Plaats;
        }
    }
}
