using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ArcheryApplication.Classes;
using ArcheryApplication.Classes.Enums;
using ArcheryApplication.GUIs;
using ArcheryApplication.Classes.Database.Repositories;
using ArcheryApplication.Classes.Database.SQL;

namespace ArcheryApplication
{
    public partial class WedstrijdForm : Form
    {
        List<Wedstrijd> _wedstrijden = new List<Wedstrijd>();
        public WedstrijdForm()
        {
            InitializeComponent();
            cbSoort.DataSource = Enum.GetValues(typeof(Soort));
            LaadWedstrijden();
        }

        private void LaadFile(string path)
        {
            List<string> wedstrijd = new List<string>();
            StreamReader reader;
            FileStream file;
            if (path != "")
            {
                file = new FileStream(path, FileMode.Open, FileAccess.Read);
                using (reader = new StreamReader(file))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        wedstrijd.Add(reader.ReadLine());
                    }
                }
                file.Close();
            }
            foreach (string s in wedstrijd)
            {
                string[] uitkomst = s.Split(';');
                _wedstrijden.Add(new Wedstrijd(Convert.ToInt32(uitkomst[0]), uitkomst[1], (Soort)Enum.Parse(typeof(Soort), uitkomst[2]), uitkomst[3]));
            }
        }

        private void LaadWedstrijden()
        {
            try
            {
                LaadFile("wedstrijdenData.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    if (dtDatum.Value != null)
                    {
                        if (tbNaam.Text != "")
                        {
                            var dateAndTime = dtDatum.Value;
                            var date = dateAndTime.ToString("dd/MM/yyyy");
                            Soort geselecteerd = (Soort)cbSoort.SelectedItem;
                            _wedstrijden.Add(new Wedstrijd(tbNaam.Text, geselecteerd, date));
                            lbWedstrijden.Items.Clear();
                            foreach (Wedstrijd wedstrijd in _wedstrijden)
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
                        MessageBox.Show("Wedstrijd is verwijderd.");
                        _wedstrijden.Remove(geselecteerdeWedstrijd);
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
