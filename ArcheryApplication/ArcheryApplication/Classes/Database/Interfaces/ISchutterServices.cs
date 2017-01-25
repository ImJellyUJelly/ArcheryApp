using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes.Database.Interfaces
{
    public interface ISchutterServices
    {
        Schutter GetSchutterById(string schutterId);
        List<Schutter> ListSchutters();

    }
}
