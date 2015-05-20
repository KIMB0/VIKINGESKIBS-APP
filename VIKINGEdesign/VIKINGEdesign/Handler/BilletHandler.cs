using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.Converter;
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
            MainViewModel.VikingeCatalogSingleton.Add(MainViewModel.AntalBorn, MainViewModel.AntalStuderende, MainViewModel.AntalVoksne,DateTimeConverter.DateTimeOffset(MainViewModel.DateTime), MainViewModel.Pris, MainViewModel.Sejltur, MainViewModel.Email, MainViewModel.Navn, MainViewModel.TelefonNr);
        }
    }
}
