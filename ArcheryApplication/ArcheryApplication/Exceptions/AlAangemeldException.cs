using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcheryApplication.Classes;

namespace ArcheryApplication.Exceptions
{
    public class AlAangemeldException
    {
        public AlAangemeldException(Schutter schutter)
        {
            MessageBox.Show($"{schutter.Naam} is al aangemeld.");
        }
    }
}
