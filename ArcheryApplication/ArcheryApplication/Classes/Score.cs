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
        public int _Score { get; private set; }
        public int Afstand { get; private set; }

        public Score()
        {

        }
        public Score(int score, int afstand)
        {
            _Score = score;
            Afstand = afstand;
        }
        //change
        public bool ChangeScore(int score)
        {
            _Score = score;
            return true;
        }
        public bool ChangeAfstand(int afstand)
        {
            Afstand = afstand;
            return true;
        }
    }
}
