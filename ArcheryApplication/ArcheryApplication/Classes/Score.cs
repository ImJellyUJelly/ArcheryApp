using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes
{
    public class Score
    {
        public int PijlEen { get; set; }
        public int PijlTwee { get; set; }
        public int PijlDrie { get; set; }
        public int PijlVier { get; set; }
        public int PijlVijf { get; set; }
        public int PijlZes { get; set; }
        public int TotaalScore { get; set; }

        public Score()
        {

        }

        //Wedstrijd met 6 pijlen per serie
        public void VerhoogScore(int p1, int p2, int p3, int p4, int p5, int p6)
        {
            PijlEen = p1;
            PijlTwee = p2;
            PijlDrie = p3;
            PijlVier = p4;
            PijlVijf = p5;
            PijlZes = p6;
            TotaalScore += PijlEen + PijlTwee + PijlDrie + PijlVier + PijlVijf + PijlZes;
        }
        //Wedstrijd met 3 pijlen per serie
        public void VerhoogScore(int p1, int p2, int p3)
        {
            PijlEen = p1;
            PijlTwee = p2;
            PijlDrie = p3;
            TotaalScore += PijlEen + PijlTwee + PijlDrie;
        }
        //Wedstrijd met 1 pijl per serie
        public void VerhoogScore(int p1)
        {
            PijlEen = p1;
            TotaalScore += PijlEen;
        }

        public int RondjeZesPijlen()
        {
            return TotaalScore;
        }
        public int RondjeDriePijlen()
        {
            int totaalScore;
            totaalScore = PijlEen + PijlTwee + PijlDrie;
            return totaalScore;
        }
        public int RondjeEenPijl()
        {
            int totaalScore;
            totaalScore = PijlEen;
            return totaalScore;
        }
    }
}
