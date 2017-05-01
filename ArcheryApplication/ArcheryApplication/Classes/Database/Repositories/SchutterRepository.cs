﻿using System.Collections.Generic;
using ArcheryApplication.Classes.Database.Interfaces;

namespace ArcheryApplication.Classes.Database.Repositories
{
    public class SchutterRepository
    {
        private ISchutterServices _schutterLogic;
        public SchutterRepository(ISchutterServices schutterLogic)
        {
            _schutterLogic = schutterLogic;
        }
        public Schutter GetSchutterById(int schutterId)
        {
            return _schutterLogic.GetSchutterById(schutterId);
        }

        public Schutter GetSchutterByBondsNr(int bondsnr)
        {
            return _schutterLogic.GetSchutterByBondsNr(bondsnr);
        }

        public List<Schutter> ListSchutters()
        {
            return _schutterLogic.ListSchutters();
        }

        public void AddSchutter(Schutter schutter)
        {
            _schutterLogic.AddSchutter(schutter);
        }

        public void EditSchutter(Schutter schutter)
        {
            _schutterLogic.EditSchutter(schutter);
        }

        public void RemoveSchutter(Schutter schutter)
        {
            _schutterLogic.RemoveSchutter(schutter);
        }
    }
}
