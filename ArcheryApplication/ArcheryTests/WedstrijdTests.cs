using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArcheryApplication.Classes;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Exceptions;
namespace ArcheryTests
{
    [TestClass]
    public class WedstrijdTests
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
        [ExpectedException(typeof(SchutterException))]
        public void Schutter_Kan_Niet_2_Keer_Aanmelden()
        {
            // Eerste keer dat een schutter wordt aangemeld
            _wedstrijd.SchutterAanmelden(_schutter1);

            // Tweede keer hoort een exception op te gooien
            _wedstrijd.SchutterAanmelden(_schutter1);
        }
        [TestMethod]
        public void F()
        {

        }
    }
}
