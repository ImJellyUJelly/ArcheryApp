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
        public Wedstrijd Wedstrijd { get; private set; }
        public Wedstrijdoverzicht(Wedstrijd wedstrijd)
        {
            InitializeComponent();
            this.Wedstrijd = wedstrijd;
            lbWedstrijdnaam.Text = wedstrijd.Naam;
            lbSoort.Text = wedstrijd.Soort.ToString();
            lbAantalSchutters.Text = wedstrijd.GetSchutters().Count.ToString();
            lbDatum.Text = wedstrijd.Datum.ToString();
            BaanUpdate();
        }

        private void btNieuweSchutter_Click(object sender, EventArgs e)
        {
            SchutterAanmelden sa = new SchutterAanmelden();
            sa.ShowDialog();
            var geselecteerdebaan = lbBanen.SelectedItem as Baan;
            if (geselecteerdebaan != null)
            {
                Wedstrijd.SchutterAanmeldenOpBaan(new Schutter(sa.Bondsnummer, sa.Naam, sa.Email, sa.Klasse, sa.Discipline, sa.Geslacht, sa.Geboortedatum, sa.Opmerking, geselecteerdebaan));
            }
            else
            {
                Wedstrijd.SchutterAanmelden(new Schutter(sa.Bondsnummer, sa.Naam, sa.Email, sa.Klasse, sa.Discipline, sa.Geslacht, sa.Geboortedatum, sa.Opmerking));
            }
            lbAantalSchutters.Text = Wedstrijd.GetSchutters().Count.ToString();
            BaanUpdate();
        }

        private void lbBanen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var geselecteerd = lbBanen.SelectedItem as Baan;
        }
        private void BaanUpdate()
        {
            lbBanen.Items.Clear();
            foreach (Baan b in Wedstrijd.GetBanen())
            {
                lbBanen.Items.Add(b);
            }
        }

        private void btBewerkSchutter_Click(object sender, EventArgs e)
        {
            var geselecteerd = lbBanen.SelectedItem as Baan;
            if (geselecteerd.Schutter != null)
            {
                SchutterAanmelden se = new SchutterAanmelden();
                se.EditSchutter(geselecteerd.Schutter.Bondsnummer, geselecteerd.Schutter.Naam, geselecteerd.Schutter.EmailAdres, geselecteerd.Schutter.Geboortedatum, geselecteerd.Schutter.Discipline, geselecteerd.Schutter.Klasse, geselecteerd.Schutter.Geslacht, geselecteerd.Schutter.Opmerking);

                se.ShowDialog();
                geselecteerd.Schutter.EditSchutter(se.Bondsnummer, se.Naam, se.Klasse, se.Discipline, se.Geslacht, se.Geboortedatum, se.Opmerking);
                BaanUpdate();
            }
            else if (geselecteerd.Schutter == null)
            {
                MessageBox.Show("Schutter niet gevonden. Raadpleeg uw nerd voor hulp.");
            }
        }

        private void btGeefScore_Click(object sender, EventArgs e)
        {
            //BUG!
            var baan = lbBanen.SelectedItem as Baan;
            if (baan != null)
            {
                if (textBox1.Text != "")
                {
                    if (baan.Schutter != null)
                    {
                        try
                        {
                            baan.Schutter.AddScore(new Score(Convert.ToInt32(textBox1.Text), baan.Afstand));
                            BaanUpdate();
                        }
                        catch (ScoreException sex)
                        {
                            MessageBox.Show(sex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Op deze baan staat geen schutter.");
                    }
                }
                else
                {
                    MessageBox.Show("Voer een score in.");
                }
            }
            else
            {
                MessageBox.Show("Selecteer de baan van een schutter.");
            }
        }
    }
}
