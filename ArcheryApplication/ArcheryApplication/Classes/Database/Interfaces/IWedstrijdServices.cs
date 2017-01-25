using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes.Database.Interfaces
{
    public interface IWedstrijdServices
    {
        Wedstrijd GetWedstrijdById(string wedstrijdId);
        List<Wedstrijd> ListWedstrijden();
        void AddWedstrijd(Wedstrijd wedstrijd);
        void EditWedstrijd(Wedstrijd wedstrijd);
        void RemoveWedstrijd(Wedstrijd wedstrijd);
        List<Baan> WedstrijdBanen();

    }
}
