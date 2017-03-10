using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes
{
    public class Scoreformulier
    {
        private int totaalScore;
        public List<Score> Scores { get; private set; }
        public int TotaalScore { get { return totaalScore; } private set { value = totaalScore; } }
        public Scoreformulier()
        {
            Scores = new List<Score>();
            TotaalScore = 0;
        }
        //update
        public bool AddScore(Score score)
        {
            Scores.Add(score);
            return true;
        }
        public bool ChangeScore(Score score)
        {
            foreach (Score S in Scores)
            {
                if (S.ID == score.ID)
                {
                    S.ChangeScore(score.AantalPunten);
                    S.ChangeAfstand(score.Afstand);
                    return true;
                }
            }
            return false;
        }
        public bool RemoveScore(Score score)
        {
            Scores.Remove(score);
            return true;
        }
        private void BerekenTotaalScore(List<Score> scores)
        {
            int totaal = 0;
            foreach (Score S in scores)
            {
                if (S.AantalPunten == 0)
                {
                    break;
                }
                totaal += S.AantalPunten;
            }
            totaalScore = totaal;

        }
    }
}
