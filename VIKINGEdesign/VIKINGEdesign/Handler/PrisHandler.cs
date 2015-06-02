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
        /// <summary>
        /// Der bliver lavet et object af MainViewModel
        /// </summary>
        public MainViewModel MainViewModel { get; set; }
        /// <summary>
        /// Contructeren tager 1 input og sætter det lig med det object der er lavet i denne klasse
        /// </summary>
        /// <param name="mainViewModel">Tager et object af typen MainViewModel som parameter</param>
        public PrisHandler(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }
        /// <summary>
        /// Methoden tager indtastede antal og ganger med prisen for den type fra DataBasen og så sætter den det lig med pris
        /// </summary>
        public void TotalPris()
        {
            MainViewModel.Pris = MainViewModel.AntalBorn * MainViewModel.VikingeCatalogSingleton.Priser.ElementAt(2).Pris +
                                 MainViewModel.AntalStuderende * MainViewModel.VikingeCatalogSingleton.Priser.ElementAt(1).Pris +
                                 MainViewModel.AntalVoksne * MainViewModel.VikingeCatalogSingleton.Priser.ElementAt(0).Pris;
            if (MainViewModel.Sejltur == true)
            {
                MainViewModel.Pris += MainViewModel.VikingeCatalogSingleton.Priser.ElementAt(3).Pris;
            }
        }
    }
}
