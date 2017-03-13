﻿using System;
using System.Collections.Generic;

namespace ArcheryApplication.Classes.Database.Interfaces
{
    public interface IWedstrijdServices
    {
        Wedstrijd GetWedstrijdById(int wedstrijdId);
        Wedstrijd GetWedstrijdByDate(DateTime date);
        List<Wedstrijd> ListWedstrijden();
        void AddWedstrijd(Wedstrijd wedstrijd);
        void EditWedstrijd(Wedstrijd wedstrijd);
        void RemoveWedstrijd(Wedstrijd wedstrijd);
        List<Baan> WedstrijdBanen(int wedstrijdId);
        void AddBaanToWedstrijd(Baan baan, int wedstrijdId);
        void EditBaanFromWedstrijd(Baan baan, int wedstrijdId);
        void RemoveBaanFromWedstrijd(Baan baan, int wedstrijdId);
    }
}