using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcheryApplication.Classes.Database.Interfaces;

namespace ArcheryApplication.Classes.Database.Repositories
{
    public class WedstrijdRepository
    {
        private IWedstrijdServices wedstrijdLogic;
        public WedstrijdRepository(IWedstrijdServices wedstrijdLogic)
        {
            this.wedstrijdLogic = wedstrijdLogic;
        }

        public void AddBaanToWedstrijd(Baan baan, int wedstrijdId)
        {
            wedstrijdLogic.AddBaanToWedstrijd(baan, wedstrijdId);
        }

        public void AddWedstrijd(Wedstrijd wedstrijd)
        {
            wedstrijdLogic.AddWedstrijd(wedstrijd);
        }

        public void EditBaanFromWedstrijd(Baan baan, int wedstrijdId)
        {
            wedstrijdLogic.EditBaanFromWedstrijd(baan, wedstrijdId);
        }

        public void EditWedstrijd(Wedstrijd wedstrijd)
        {
            wedstrijdLogic.EditWedstrijd(wedstrijd);
        }

        public Wedstrijd GetWedstrijdByDate(DateTime date)
        {
            return wedstrijdLogic.GetWedstrijdByDate(date);
        }

        public Wedstrijd GetWedstrijdById(int wedstrijdId)
        {
            return wedstrijdLogic.GetWedstrijdById(wedstrijdId);
        }

        public List<Wedstrijd> ListWedstrijden()
        {
            return wedstrijdLogic.ListWedstrijden();
        }

        public void RemoveBaanFromWedstrijd(Baan baan, int wedstrijdId)
        {
            wedstrijdLogic.RemoveBaanFromWedstrijd(baan, wedstrijdId);
        }

        public void RemoveWedstrijd(Wedstrijd wedstrijd)
        {
            wedstrijdLogic.RemoveWedstrijd(wedstrijd);
        }

        public List<Baan> WedstrijdBanen(int wedstrijdId)
        {
            return wedstrijdLogic.WedstrijdBanen(wedstrijdId);
        }
    }
}
