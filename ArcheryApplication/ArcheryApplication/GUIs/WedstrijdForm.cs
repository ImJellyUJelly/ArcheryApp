using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcheryApplication.Classes;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.GUIs;

namespace ArcheryApplication
{
    public partial class WedstrijdForm : Form
    {
        List<Wedstrijd> wedstrijden = new List<Wedstrijd>();
        public WedstrijdForm()
        {
            InitializeComponent();
            cbSoort.DataSource = Enum.GetValues(typeof(Soort));
            //wedstrijden = db.GetWedstrijden();
            if (wedstrijden != null)
            {
                foreach (Wedstrijd W in wedstrijden)
                {
                    lbWedstrijden.Items.Add(W);
                }
            }
        }

        private void NieuweWedstrijd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSoort.SelectedItem != null)
                {
                    if (dtDatum.Value != null)
                    {
                        if (tbNaam.Text != "")
                        {
                            var dateAndTime = dtDatum.Value;
                            var date = dateAndTime.ToString("dd/MM/yyyy");
                            Soort geselecteerd = (Soort)cbSoort.SelectedItem;
                            wedstrijden.Add(new Wedstrijd(tbNaam.Text, geselecteerd, date));
                            lbWedstrijden.Items.Clear();
                            foreach (Wedstrijd wedstrijd in wedstrijden)
                            {
                                lbWedstrijden.Items.Add(wedstrijd);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vul een naam in.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vul een datum in.");
                    }
                }
                else
                {
                    MessageBox.Show("Vul een wedstrijdsoort in.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbWedstrijden_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectedWedstrijd();
        }

        //om de listboxen op het form te refreshen, nadat er changes hebben plaatsgevonden
        private void RefreshListboxen()
        {
            if (wedstrijden != null)
            {
                lbWedstrijden.Items.Clear();
                foreach (Wedstrijd W in wedstrijden)
                {
                    lbWedstrijden.Items.Add(W);
                }
            }
        }
        private void selectedWedstrijd()
        {
            try
            {
                var geselecteerd = lbWedstrijden.SelectedItem as Wedstrijd;

                Wedstrijdoverzicht WO = new Wedstrijdoverzicht(geselecteerd);
                WO.ShowDialog();
                RefreshListboxen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbWedstrijden_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var geselecteerd = lbWedstrijden.SelectedItem as Wedstrijd;
                if (geselecteerd != null)
                {
                    tbNaam.Text = geselecteerd.Naam;
                    DateTime datum = DateTime.Parse(geselecteerd.Datum);
                    dtDatum.Value = datum;
                    cbSoort.Text = geselecteerd.Soort.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBewerkWedstrijd_Click(object sender, EventArgs e)
        {
            try
            {
                var geselecteerdeWedstrijd = lbWedstrijden.SelectedItem as Wedstrijd;
                if (geselecteerdeWedstrijd != null)
                {
                    var dateAndTime = dtDatum.Value;
                    var date = dateAndTime.ToString("dd/MM/yyyy");

                    geselecteerdeWedstrijd.Naam = tbNaam.Text;
                    geselecteerdeWedstrijd.Datum = date;
                    geselecteerdeWedstrijd.Soort = (Soort)cbSoort.SelectedItem;

                    RefreshListboxen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btVerwijderWedstrijd_Click(object sender, EventArgs e)
        {
            try
            {
                var geselecteerdeWedstrijd = lbWedstrijden.SelectedItem as Wedstrijd;
                if (geselecteerdeWedstrijd != null)
                {
                    WarningBox WB = new WarningBox();
                    WB.ShowDialog();
                    if (WB.Doorgaan() == false)
                    {
                        MessageBox.Show("Wedstrijd is verwijderd.");
                        wedstrijden.Remove(geselecteerdeWedstrijd);
                        RefreshListboxen();
                    }
                    else
                    {
                        MessageBox.Show("U bent niet gemachtigd een wedstrijd te verwijderen. Raadpleeg uw nerd voor meer informatie.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
