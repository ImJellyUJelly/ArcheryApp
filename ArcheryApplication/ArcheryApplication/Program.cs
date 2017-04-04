using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcheryApplication.Classes;

namespace ArcheryApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<Wedstrijd> wedstrijden = new List<Wedstrijd>();
            Application.Run(new WedstrijdForm(wedstrijden));
        }
    }
}
