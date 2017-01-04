using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes
{
    public class Score
    {
        public int _Score { get; private set; }
        public Score()
        {
            _Score = 0;
        }
        public Score(int score)
        {
            _Score = score;
        }

        public void VerhoogScore(int score)
        {
            _Score += score;
        }
        public void EditScore(int score)
        {
            _Score = score;
        }
        public void DeleteScore()
        {
            _Score = 0;
        }
    }
}
