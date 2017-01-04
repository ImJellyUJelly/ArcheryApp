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
        public int Bondsnummer { get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
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
            if (tbBN.Text != null && tbNaam.Text != null && dtLeeftijd.Value != null && cbDiscipline.Text != null && cbKlasse.Text != null && cbGeslacht.Text != null)
            {
                Bondsnummer = Convert.ToInt32(tbBN.Text);
                Naam = tbNaam.Text;
                Geboortedatum = dtLeeftijd.Value;
                _Discipline = (Discipline)cbDiscipline.SelectedItem;
                _Klasse = (Klasse)cbKlasse.SelectedItem;
                _Geslacht = (Geslacht)cbGeslacht.SelectedItem;
                Opmerking = tbOpmerking.Text;

                tbBN.Clear();
                tbNaam.Clear();
                dtLeeftijd.Value = DateTime.Now;
                tbOpmerking.Clear();
                Close();
            }
        }

        public void editSchutter(int b, string n, DateTime G, Discipline D, Klasse K, Geslacht Ge, string O)
        {
            string Dis = D.ToString();
            string Kla = K.ToString();
            string Ges = G.ToString();
            tbBN.Text = b.ToString();
            tbNaam.Text = n;
            dtLeeftijd.Value = G;
            cbDiscipline.Text = Dis;
            cbKlasse.Text = Kla;
            cbGeslacht.Text = Ges;
            tbOpmerking.Text = O;

            Bondsnummer = Convert.ToInt32(tbBN.Text);
            Naam = tbNaam.Text;
            Geboortedatum = dtLeeftijd.Value;
            _Discipline = (Discipline)cbDiscipline.SelectedItem;
            _Klasse = (Klasse)cbKlasse.SelectedItem;
            _Geslacht = (Geslacht)cbGeslacht.SelectedItem;
            Opmerking = tbOpmerking.Text;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //public void createSchutter()
        //{
        //    var geselecteerd_D = (Discipline)cbDiscipline.SelectedItem;
        //    var geselecteerd_K = (Klasse)cbKlasse.SelectedItem;
        //    var geselecteerd_G = (Geslacht)cbGeslacht.SelectedItem;
        //    Bondsnummer = Convert.ToInt32(tbBN.Text);
        //    Naam = tbNaam.Text;
        //    Geboortedatum = dtLeeftijd.Value;
        //    _Discipline = geselecteerd_D;
        //    _Klasse = geselecteerd_K;
        //    _Geslacht = geselecteerd_G;
        //    Opmerking = tbOpmerking.Text;

        //    Schutter schutter = new Schutter(Bondsnummer, Naam, _Klasse, _Discipline, _Geslacht, Geboortedatum, Opmerking);
        //}
    }
}
