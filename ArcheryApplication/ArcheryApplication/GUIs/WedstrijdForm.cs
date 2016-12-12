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
using ArcheryApplication.GUIs;
using ArcheryApplication.Exceptions;

namespace ArcheryApplication
{
    public partial class WedstrijdForm : Form
    {
        List<Wedstrijd> wedstrijden = new List<Wedstrijd>();
        SchutterAanmelden SA;
        public WedstrijdForm()
        {
            InitializeComponent();
            cbSoort.DataSource = Enum.GetValues(typeof(Soort));
        }

        private void NieuweWedstrijd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSoort.Text != "")
                {
                    Soort geselecteerd = (Soort)cbSoort.SelectedItem;
                    wedstrijden.Add(new Wedstrijd(tbNaam.Text, geselecteerd, dtDatum.Value));
                    lbWedstrijden.Items.Clear();
                    foreach (Wedstrijd wedstrijd in wedstrijden)

                    {
                        lbWedstrijden.Items.Add(wedstrijd);
                    }
                }
                else
                {
                    MessageBox.Show("Vul een wedstrijdsoort in.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void selectedWedstrijd()
        {
            try
            {
                var geselecteerd = lbWedstrijden.SelectedItem as Wedstrijd;

                Wedstrijdoverzicht WO = new Wedstrijdoverzicht(geselecteerd);
                WO.ShowDialog();
                //lbSchutters.DataSource = geselecteerd.getBanen();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbWedstrijden_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWedstrijd();
        }

        private void lbSchutters_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var geselecteerd = lbSchutters.SelectedItem as Baan;
            //if (geselecteerd.Schutter == null)
            //{

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SA = new SchutterAanmelden();
            SA.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var geselecteerdeSchutter = lbSchutters.SelectedItem as Schutter;
            //    SA = new SchutterAanmelden();
            //    SA.editSchutter(geselecteerdeSchutter);
            //    SA.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btBaanToewijzen_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var geselecteerdeSchutter = lbSchutters.SelectedItem as Schutter;

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var geselecteerd = lbWedstrijden.SelectedItem as Wedstrijd;
            geselecteerd.testSchutters();
        }

        private void lbWedstrijden_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var geselecteerde_Wedstrijd = lbWedstrijden.SelectedItem as Wedstrijd;
                Wedstrijdoverzicht WO = new Wedstrijdoverzicht(geselecteerde_Wedstrijd);
                WO.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
