using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheryApplication.Classes.Enums;

namespace ArcheryApplication.Classes
{
    public class Schutter
    {
        public int ID { get; private set; }
        public int Bondsnummer { get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public Baan Baan { get; set; }
        public Klasse Klasse { get; set; }
        public Discipline Discipline { get; set; }
        public Geslacht Geslacht { get; set; }
        public string Opmerking { get; set; }
        public Scoreformulier ScoreFormulier { get; private set; }
        public Vereniging Vereniging { get; set; }

        public Schutter(int bondsnr, string naam, Klasse k, Discipline d, Geslacht g, DateTime geb, string opmerking)
        {
            Bondsnummer = bondsnr;
            Naam = naam;
            Klasse = k;
            Discipline = d;
            Geslacht = g;
            Geboortedatum = geb;
            Opmerking = opmerking;
            ScoreFormulier = new Scoreformulier();
        }
        public Schutter(int id, int bondsnr, string naam, Klasse k, Discipline d, Geslacht g, DateTime geb, string opmerking, Vereniging vereniging)
        {
            ID = id;
            Bondsnummer = bondsnr;
            Naam = naam;
            Klasse = k;
            Discipline = d;
            Geslacht = g;
            Geboortedatum = geb;
            Opmerking = opmerking;
            ScoreFormulier = new Scoreformulier();
            Vereniging = vereniging;
        }

        public void editSchutter(string naam, Klasse k, Discipline d, Geslacht g, DateTime geb, string opmerking)
        {
            Naam = naam;
            Klasse = k;
            Discipline = d;
            Geslacht = g;
            Geboortedatum = geb;
            Opmerking = opmerking;
            ScoreFormulier = new Scoreformulier();
        }

        public void AddScore(Score score)
        {
            ScoreFormulier.AddScore(score);
        }

        public int compareSchutters(Schutter andereSchutter)
        {
            int result = Bondsnummer.CompareTo(andereSchutter.Bondsnummer);
            return result;
        }
        public override string ToString()
        {
            return $"{Bondsnummer} { Naam }, Klasse: { Klasse }, Geslacht: { Geslacht } Discipline: { Discipline }, Geb.Datum: { Geboortedatum.ToShortDateString() } - Score: { ScoreFormulier.TotaalScore.ToString() }";
        }
    }
}
