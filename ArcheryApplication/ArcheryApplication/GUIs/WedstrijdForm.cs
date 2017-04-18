using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ArcheryApplication.Classes;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.GUIs;

namespace ArcheryApplication
{
    public partial class WedstrijdForm : Form
    {
        private readonly List<Wedstrijd> _wedstrijden;
        public App App { get; private set; }
        public WedstrijdForm(App app)
        {
            InitializeComponent();
            App = app;
            _wedstrijden = app.GetWedstrijden();

            cbSoort.DataSource = Enum.GetValues(typeof(Soort));
            LaadWedstrijden();
        }

        private void LaadWedstrijden()
        {
            if (_wedstrijden != null)
            {
                foreach (Wedstrijd w in _wedstrijden)
                {
                    lbWedstrijden.Items.Add(w);
                }
            }
        }

        private void NieuweWedstrijd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSoort.SelectedItem != null)
                {
                    if (!(dtDatum.Value > DateTime.Now))
                    {
                        if (tbNaam.Text != "")
                        {
                            var dateAndTime = dtDatum.Value;
                            var date = dateAndTime.ToString("dd/MM/yyyy");
                            string soort = cbSoort.Text;
                            _wedstrijden.Add(App.AddWedstrijd(tbNaam.Text, date, soort));
                            RefreshListboxen();
                        }
                        else
                        {
                            MessageBox.Show(@"Vul een naam in.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Vul een datum in.");
                    }
                }
                else
                {
                    MessageBox.Show(@"Vul een wedstrijdsoort in.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbWedstrijden_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectedWedstrijd();
        }

        //om de listboxen op het form te refreshen, nadat er changes hebben plaatsgevonden
        private void RefreshListboxen()
        {
            if (_wedstrijden != null)
            {
                lbWedstrijden.Items.Clear();
                foreach (Wedstrijd w in _wedstrijden)
                {
                    lbWedstrijden.Items.Add(w);
                }
            }
        }
        private void SelectedWedstrijd()
        {
            try
            {
                var geselecteerd = lbWedstrijden.SelectedItem as Wedstrijd;

                Wedstrijdoverzicht wo = new Wedstrijdoverzicht(geselecteerd);
                wo.ShowDialog();
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
                    //om de tijd korter te maken
                    var dateAndTime = dtDatum.Value;
                    var date = dateAndTime.ToString("dd/MM/yyyy");

                    geselecteerdeWedstrijd.BewerkWedstrijd(tbNaam.Text, (Soort)cbSoort.SelectedItem, date);

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
                    WarningBox wb = new WarningBox();
                    wb.ShowDialog();
                    if (wb.Doorgaan() == false)
                    {
                        MessageBox.Show(@"Wedstrijd is verwijderd.");
                        _wedstrijden.Remove(geselecteerdeWedstrijd);
                        RefreshListboxen();
                    }
                    else
                    {
                        MessageBox.Show(@"U bent niet gemachtigd een wedstrijd te verwijderen. Raadpleeg uw nerd voor meer informatie.");
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
