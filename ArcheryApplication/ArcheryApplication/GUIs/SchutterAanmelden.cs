using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.Classes;

namespace ArcheryApplication.GUIs
{
    public partial class SchutterAanmelden : Form
    {
        public string Naam { get; set; }
        public DateTime Leeftijd { get; set; }
        public Discipline _Discipline { get; set; }
        public Klasse _Klasse { get; set; }
        public Geslacht _Geslacht { get; set; }
        public string Opmerking { get; set; }
        public SchutterAanmelden()
        {
            InitializeComponent();
            cbDiscipline.DataSource = Enum.GetValues(typeof(Discipline));
            cbKlasse.DataSource = Enum.GetValues(typeof(Klasse));
            cbGeslacht.DataSource = Enum.GetValues(typeof(Geslacht));
        }

        private void btOpslaan_Click(object sender, EventArgs e)
        {
            createSchutter();
            Close();
        }

        public void editSchutter(Schutter schutter)
        {
            Naam = schutter.Naam;
            Leeftijd = schutter.Geboortedatum;
            _Discipline = schutter.Discipline;
            _Klasse = schutter.Klasse;
            _Geslacht = schutter.Geslacht;
            Opmerking = schutter.Opmerking;

            tbNaam.Text = Naam;
            dtLeeftijd.Value = Leeftijd;
            cbDiscipline.Text = _Discipline.ToString();
            cbKlasse.Text = _Klasse.ToString();
            cbGeslacht.Text = _Geslacht.ToString();
            tbOpmerking.Text = Opmerking;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void createSchutter()
        {
            var geselecteerd_D = (Discipline)cbDiscipline.SelectedItem;
            var geselecteerd_K = (Klasse)cbKlasse.SelectedItem;
            var geselecteerd_G = (Geslacht)cbGeslacht.SelectedItem;
            Naam = tbNaam.Text;
            Leeftijd = dtLeeftijd.Value;
            _Discipline = geselecteerd_D;
            _Klasse = geselecteerd_K;
            _Geslacht = geselecteerd_G;
            Opmerking = tbOpmerking.Text;

            Schutter schutter = new Schutter(Naam, _Klasse, _Discipline, _Geslacht, Opmerking);

            Close();
        }
    }
}
