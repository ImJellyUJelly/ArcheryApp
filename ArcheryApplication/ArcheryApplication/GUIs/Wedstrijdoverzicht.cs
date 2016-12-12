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

            foreach (Baan B in wedstrijd.getBanen())
            {
                lbBanen.Items.Add(B);
            }
        }

        private void btNieuweSchutter_Click(object sender, EventArgs e)
        {
            SchutterAanmelden SA = new SchutterAanmelden();
            SA.ShowDialog();
            
        }
    }
}
