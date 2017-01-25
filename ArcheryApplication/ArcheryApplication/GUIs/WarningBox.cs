using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheryApplication.GUIs
{
    public partial class WarningBox : Form
    {
        public WarningBox()
        {
            InitializeComponent();
        }

        private void btDoorgaan_Click(object sender, EventArgs e)
        {
            Doorgaan();
            Close();
        }

        private void btTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool Doorgaan()
        {
            return true;
        }
    }
}
