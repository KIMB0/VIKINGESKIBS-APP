using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.Model;
using VIKINGEdesign.ViewModel;

namespace VIKINGEdesign.Handler
{
    class SkibeHandler
    {
        /// <summary>
        /// Her bliver der lavet et objekt af MainViewModel.
        /// </summary>
        public MainViewModel MainViewModel { get; set; }

      /// <summary>
      ///  I denne parametre bliver der oprettet en instans af MainViewModel. 
      /// </summary>
        /// <param name="mainViewModel">Tager MainViewModel som parameter</param>
        public SkibeHandler(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        /// <summary>
        ///  Denne tager input af typen Vikingeskibe og sætter det li med selectedSkibe.
        /// </summary>
        /// <param name="s">Tager MainViewModel.SelectedSkibe, som parametre.</param>

        public void SetSelectedSkibe(Vikingeskibe s)
        {
            MainViewModel.SelectedSkibe = s;
        }
    }
}
