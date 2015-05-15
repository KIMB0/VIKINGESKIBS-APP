using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.ViewModel;

namespace VIKINGEdesign.Handler
{
    class BilletHandler
    {
        public MainViewModel MainViewModel { get; set; }

        public BilletHandler(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void CreateBillet()
        {
            MainViewModel.VikingeCatalogSingleton.Add(MainViewModel.Billet.AntalBorn, MainViewModel.Billet.AntalStuderende, MainViewModel.Billet.AntalVoksne, MainViewModel.Billet.Billet_id, MainViewModel.Billet.Kunde_id, MainViewModel.Billet.Pris, MainViewModel.Billet.DateTime, MainViewModel.Billet.Sejltur, MainViewModel.Kunde.Email, MainViewModel.Kunde.Navn, MainViewModel.Kunde.Kunde_id, MainViewModel.Kunde.TelefonNr);
        }
    }
}
