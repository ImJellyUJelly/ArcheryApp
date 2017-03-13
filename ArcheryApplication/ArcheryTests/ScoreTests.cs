using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArcheryApplication.Classes;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Exceptions;

namespace ArcheryTests
{
    [TestClass]
    public class ScoreTests
    {
        private Wedstrijd _wedstrijd;
        private Schutter _schutter1;
        private Schutter _schutter2;

        [TestInitialize]
        public void TestInitialize()
        {
            _wedstrijd = new Wedstrijd(0, "Indoorwedstrijd", Soort.Indoorcompetitie, "10-12-2017");

            _schutter1 = new Schutter(0, 161378, "Jelle Schrader", Klasse.Senior, Discipline.Recurve, Geslacht.Heren, DateTime.Now, "Geen opmerking", null);
            _schutter2 = new Schutter(1, 161379, "Florentina van den Hurk", Klasse.Senior, Discipline.Compound, Geslacht.Dames, DateTime.Now, "Geen opmerking", null);
        }
        [TestMethod]
        [ExpectedException(typeof(ScoreException))]
        public void Score_Buiten_De_0_en_360_Punten()
        {
            _wedstrijd.SchutterAanmelden(_schutter1);

            _schutter1.AddScore(new Score(1, 361, 70));

            // Assert wordt afgehandeld door exception.
        }
        [TestMethod]
        public void Score_Binnen_De_0_en_360_PunteN()
        {
            _wedstrijd.SchutterAanmelden(_schutter1);

            _schutter1.AddScore(new Score(0, 359, 70));

            Assert.AreEqual(359, _schutter1.ScoreFormulier.TotaalScore);
        }
    }
}
