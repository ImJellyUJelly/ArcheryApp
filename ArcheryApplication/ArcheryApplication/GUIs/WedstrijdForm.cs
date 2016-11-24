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
        public WedstrijdForm()
        {
            InitializeComponent();
            cbSoort.DataSource = Enum.GetValues(typeof(Soort));
        }

        private void NieuweWedstrijd_Click(object sender, EventArgs e)
        {
            if (cbSoort.Text != "")
            {
                Soort geselecteerd = (Soort)cbSoort.SelectedItem;
                wedstrijden.Add(new Wedstrijd(tbNaam.Text, geselecteerd, dtDatum.Value));
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
        private void selectedWedstrijd()
        {
            var geselecteerd = lbWedstrijden.SelectedItem as Wedstrijd;
            foreach (Baan banen in geselecteerd.getBanen())
            {
                lbSchutters.Items.Add(banen);
            }
        }

        private void lbWedstrijden_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWedstrijd();
        }

        private void lbSchutters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var geselecteerd = lbSchutters.SelectedItem as Baan;
            if (geselecteerd.Schutter == null)
            {
                SchutterAanmelden SA = new SchutterAanmelden();
                SA.ShowDialog();
            }
        }
    }
}
