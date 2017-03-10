using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheryApplication.Classes.Database.Interfaces;

namespace ArcheryApplication.Classes.Database.Repositories
{
    public class BaanRepository
    {
        private IBaanServices baanLogic;
        public BaanRepository(IBaanServices baanLogic)
        {
            this.baanLogic = baanLogic;
        }

        public void AddBaan(Baan baan)
        {
            baanLogic.AddBaan(baan);
        }

        public void AddSchutterTobaan(Schutter schutter, int baanId)
        {
            baanLogic.AddSchutterTobaan(schutter, baanId);
        }

        public void EditBaan(Baan baan)
        {
            baanLogic.EditBaan(baan);
        }

        public Baan GetBaanByID(int baanId)
        {
            return baanLogic.GetBaanByID(baanId);
        }

        public Baan GetBaanByNummer(int baanNummer)
        {
            return baanLogic.GetBaanByNummer(baanNummer);
        }

        public List<Baan> ListBanen()
        {
            return baanLogic.ListBanen();
        }

        public List<Schutter> ListSchuttersOpBaan(int baanId)
        {
            return baanLogic.ListSchuttersOpBaan(baanId);
        }

        public void RemoveBaan(Baan baan)
        {
            baanLogic.RemoveBaan(baan);
        }

        public void RemoveSchutterFromBaan(Schutter schutter, int baanId)
        {
            baanLogic.RemoveSchutterFromBaan(schutter, baanId);
        }
    }
}
