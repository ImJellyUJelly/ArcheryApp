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
        public string Email { get; set; }
        public DateTime Geboortedatum { get; set; }
        public Discipline Discipline { get; set; }
        public Klasse Klasse { get; set; }
        public string Geslacht { get; set; }
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
                if (tbBN.Text == "")
                {
                    Bondsnummer = -1;
                    Naam = tbNaam.Text;
                    Geboortedatum = dtLeeftijd.Value;
                    Email = tbEmail.Text;
                    Discipline = (Discipline)cbDiscipline.SelectedItem;
                    Klasse = (Klasse)cbKlasse.SelectedItem;
                    Geslacht = GeslachtCheck(cbGeslacht.Text);
                    Opmerking = tbOpmerking.Text;

                    tbBN.Clear();
                    tbNaam.Clear();
                    tbEmail.Clear();
                    dtLeeftijd.Value = DateTime.Now;
                    tbOpmerking.Clear();
                    Close();
                }
                else
                {
                    Bondsnummer = Convert.ToInt32(tbBN.Text);
                    Naam = tbNaam.Text;
                    Geboortedatum = dtLeeftijd.Value;
                    Email = tbEmail.Text;
                    Discipline = (Discipline)cbDiscipline.SelectedItem;
                    Klasse = (Klasse)cbKlasse.SelectedItem;
                    Geslacht = GeslachtCheck(cbGeslacht.Text);
                    Opmerking = tbOpmerking.Text;

                    tbBN.Clear();
                    tbNaam.Clear();
                    tbEmail.Clear();
                    dtLeeftijd.Value = DateTime.Now;
                    tbOpmerking.Clear();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Aanmelden mislukt, raadpleeg uw nerd voor hulp.");
            }
        }

        public void EditSchutter(int b, string n, string em, DateTime g, Discipline d, Klasse k, string ge, string o)
        {
            string dis = d.ToString();
            string kla = k.ToString();
            string ges = g.ToString();
            tbBN.Text = b.ToString();
            tbNaam.Text = n;
            dtLeeftijd.Value = g;
            tbEmail.Text = em;
            cbDiscipline.Text = dis;
            cbKlasse.Text = kla;
            cbGeslacht.Text = ges;
            tbOpmerking.Text = o;

            Bondsnummer = Convert.ToInt32(tbBN.Text);
            Naam = tbNaam.Text;
            Geboortedatum = dtLeeftijd.Value;
            Email = tbEmail.Text;
            Discipline = (Discipline)cbDiscipline.SelectedItem;
            Klasse = (Klasse)cbKlasse.SelectedItem;
            Geslacht = GeslachtCheck(cbGeslacht.Text);
            Opmerking = tbOpmerking.Text;
        }

        private string GeslachtCheck(string geslacht)
        {
            if (geslacht == "Heren")
            {
                return "H";
            }
            if (geslacht == "Dames")
            {
                return "D";
            }
            return "O";
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
