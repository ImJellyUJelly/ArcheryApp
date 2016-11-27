using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Classes;
using ArcheryApplication.GUIs;
using ArcheryApplication.Exceptions;

namespace ScoreTests
{
    [TestClass]
    public class SchutterTests
    {
        Schutter JelleSchrader = new Schutter("Jelle Schrader", Klasse.Senior, Discipline.Recurve, Geslacht.Heren, null);
        Schutter FlorentinaVDHurk = new Schutter("Florentina van den Hurk", Klasse.Junior, Discipline.Compound, Geslacht.Dames, null);
        Schutter AndereJelle = new Schutter("Jelle Schrader", Klasse.Senior, Discipline.Recurve, Geslacht.Heren, null);

        [TestMethod]
        public void CompareMethode()
        {
            //Jelle en Florentina zijn niet dezelfde schutter
            Assert.AreEqual(1, JelleSchrader.compareSchutters(FlorentinaVDHurk));
            //Jelle en AndereJelle zijn hetzelfde
            Assert.AreEqual(0, JelleSchrader.compareSchutters(AndereJelle));
        }

    }
}
