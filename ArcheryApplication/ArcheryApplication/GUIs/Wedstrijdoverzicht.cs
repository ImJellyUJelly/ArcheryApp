using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcheryApplication.Classes;
using ArcheryApplication.Classes.Enums;

namespace ArcheryApplication.GUIs
{
    public partial class Wedstrijdoverzicht : Form
    {
        public Wedstrijd wedstrijd { get; set; }
        public Wedstrijdoverzicht(Wedstrijd wedstrijd)
        {
            InitializeComponent();
            this.wedstrijd = wedstrijd;
            lbWedstrijdnaam.Text = wedstrijd.Naam;
            lbSoort.Text = wedstrijd.Soort.ToString();
            lbAantalSchutters.Text = wedstrijd.getSchutters().Count.ToString();
            lbDatum.Text = wedstrijd.Datum.ToString();

            if (wedstrijd.Soort == Soort.Indoorcompetitie)
            {
                tbP4.Enabled = false;
                tbP5.Enabled = false;
                tbP6.Enabled = false;
            }

            foreach (Baan B in wedstrijd.getBanen())
            {
                lbBanen.Items.Add(B);
            }
        }

        private void btNieuweSchutter_Click(object sender, EventArgs e)
        {
            SchutterAanmelden SA = new SchutterAanmelden();
            SA.ShowDialog();

            wedstrijd.schutterAanmelden(new Schutter(SA.Bondsnummer, SA.Naam, SA._Klasse, SA._Discipline, SA._Geslacht, SA.Geboortedatum, SA.Opmerking));

            lbAantalSchutters.Text = wedstrijd.getSchutters().Count.ToString();
            BaanUpdate();
        }

        private void lbBanen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var geselecteerd = lbBanen.SelectedItem as Baan;
        }
        private void BaanUpdate()
        {
            lbBanen.Items.Clear();
            foreach (Baan B in wedstrijd.getBanen())
            {
                lbBanen.Items.Add(B);
            }
        }

        private void btBewerkSchutter_Click(object sender, EventArgs e)
        {
            var geselecteerd = lbBanen.SelectedItem as Baan;
            if (geselecteerd.Schutter != null)
            {
                SchutterAanmelden SE = new SchutterAanmelden();
                SE.editSchutter(geselecteerd.Schutter.Bondsnummer, geselecteerd.Schutter.Naam, geselecteerd.Schutter.Geboortedatum, geselecteerd.Schutter.Discipline, geselecteerd.Schutter.Klasse, geselecteerd.Schutter.Geslacht, geselecteerd.Schutter.Opmerking);

                SE.ShowDialog();
                geselecteerd.Schutter.Bondsnummer = SE.Bondsnummer;
                geselecteerd.Schutter.Naam = SE.Naam;
                geselecteerd.Schutter.Geboortedatum = SE.Geboortedatum;
                geselecteerd.Schutter.Discipline = SE._Discipline;
                geselecteerd.Schutter.Klasse = SE._Klasse;
                geselecteerd.Schutter.Geslacht = SE._Geslacht;
                geselecteerd.Schutter.Opmerking = SE.Opmerking;
                BaanUpdate();
            }
            else if (geselecteerd.Schutter == null)
            {
                MessageBox.Show("Schutter not found. Raadpleeg uw nerd voor hulp.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wedstrijd.Soort == Soort.Indoorcompetitie)
            { 
                var baan = lbBanen.SelectedItem as Baan;
                baan.Schutter.AddScore();
            }
            else if (wedstrijd.Soort == Soort.JeugdFITA)
            {

            }
            else if (wedstrijd.Soort == Soort.WA1440)
            {

            }
            else if (wedstrijd.Soort == Soort.Veld)
            {

            }
            else
            {

            }
        }
    }
}
