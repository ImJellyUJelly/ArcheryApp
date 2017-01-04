using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes
{
    public class Scoreformulier
    {
        List<Score> TotaalScore = new List<Score>();
        public Wedstrijd Wedstrijd { get; set; }


        public Scoreformulier(Wedstrijd wedstrijd)
        {
            Wedstrijd = wedstrijd;
        }

        public void BepaalAantalBeurten()
        {
            if (Wedstrijd.Soort == Enums.Soort.Indoorcompetitie)
            {

            }
        }
    }
}
