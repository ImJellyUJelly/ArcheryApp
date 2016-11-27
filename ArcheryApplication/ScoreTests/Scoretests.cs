using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArcheryApplication;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Classes;
using ArcheryApplication.GUIs;
using ArcheryApplication.Exceptions;

namespace ScoreTests
{
    [TestClass]
    public class Scoretests
    {
        Score score = new Score();
        [TestMethod]
        public void TotaalScoreBerekenen()
        {
            //eerste serie
            score.VerhoogScore(10, 10, 10, 10, 10, 10);
            Assert.AreEqual(60, score.TotaalScore);
            //tweede serie
            score.VerhoogScore(10, 10, 10, 9, 9, 9);
            Assert.AreEqual(117, score.TotaalScore);
            //derde serie
            score.VerhoogScore(10, 9, 9, 10, 10, 10);
            Assert.AreEqual(175, score.TotaalScore);
        }
        [TestMethod]
        public void RondjeDriePijlen()
        {
            score.PijlEen = 10;
            score.PijlTwee = 9;
            score.PijlDrie = 10;

            Assert.AreEqual(29, score.RondjeDriePijlen());
        }
        [TestMethod]
        public void TotaalScore_36_pijlen()
        {
            score.VerhoogScore(10, 9, 9, 10, 10, 10);//1
            score.VerhoogScore(10, 9, 10, 10, 10, 10);//2
            score.VerhoogScore(10, 10, 9, 8, 9, 10);//3
            score.VerhoogScore(10, 10, 10, 9, 10, 10);//4
            score.VerhoogScore(9, 10, 9, 10, 10, 10);//5
            score.VerhoogScore(9, 10, 10, 10, 10, 10);//6

            Assert.AreEqual(349, score.TotaalScore);
        }
        [TestMethod]
        public void EenPijl()
        {
            score.PijlEen = 10;
            Assert.AreNotEqual(9, score.RondjeEenPijl());
            Assert.AreEqual(10, score.RondjeEenPijl());
        }
    }
}
