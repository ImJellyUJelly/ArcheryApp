using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Exceptions
{
    class NormalException : Exception
    {
        public NormalException(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
    }
}
