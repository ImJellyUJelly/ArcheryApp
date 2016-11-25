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

namespace ArcheryApplication.GUIs
{
    public partial class SchuttersLijst : Form
    {
        public List<Schutter> Schutters { get; set; }
        public SchuttersLijst(List<Schutter> schutters)
        {
            InitializeComponent();
            Schutters = schutters;
            foreach(Schutter _schutters in Schutters)
            {
                lbSchutters.Items.Add(_schutters);
            }
        }
    }
}
