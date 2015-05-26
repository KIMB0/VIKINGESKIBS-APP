using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.Model;
using VIKINGEdesign.ViewModel;

namespace VIKINGEdesign.Handler
{
    class PrisHandler
    {
        private decimal _totalPris;
        public MainViewModel MainViewModel { get; set; }
        //public VikingeCatalogSingleton VikingeCatalogSingleton { get; set; }
        public PrisHandler(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void TotalPris()
        {
            MainViewModel.Pris = MainViewModel.AntalBorn * MainViewModel.VikingeCatalogSingleton.Priser.ElementAt(2).Pris +
                                 MainViewModel.AntalStuderende * MainViewModel.VikingeCatalogSingleton.Priser.ElementAt(1).Pris +
                                 MainViewModel.AntalVoksne * MainViewModel.VikingeCatalogSingleton.Priser.ElementAt(0).Pris;
        }
    }
}
