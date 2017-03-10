using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes
{
    public class Score
    {
        public  int ID { get; private set; }
        public int AantalPunten { get; private set; }
        public int Afstand { get; private set; }

        public Score()
        {

        }
        public Score(int score, int afstand)
        {
            AantalPunten = score;
            Afstand = afstand;
        }
        //change
        public bool ChangeScore(int score)
        {
            AantalPunten = score;
            return true;
        }
        public bool ChangeAfstand(int afstand)
        {
            Afstand = afstand;
            return true;
        }
    }
}
