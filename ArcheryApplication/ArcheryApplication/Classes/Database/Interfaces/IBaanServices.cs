using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryApplication.Classes.Database.Interfaces
{
    public interface IBaanServices
    {
        Baan GetBaanByID(int baanId);
        Baan GetBaanByNummer(int baanNummer);
        List<Baan> ListBanen();
        List<Schutter> ListSchuttersOpBaan(int baanId);
        void AddBaan(Baan baan);
        void EditBaan(Baan baan);
        void RemoveBaan(Baan baan);
        void AddSchutterTobaan(Schutter schutter, int baanId);
        void RemoveSchutterFromBaan(Schutter schutter, int baanId);
    }
}
