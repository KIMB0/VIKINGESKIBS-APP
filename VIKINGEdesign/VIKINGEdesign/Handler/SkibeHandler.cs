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
        public MainViewModel MainViewModel { get; set; }

      /// <summary>
      ///  I denne parametre bliver der oprettet en instans af MainViewModel. 
      /// </summary>
      /// <param name="mainViewModel"></param>
        public SkibeHandler(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        /// <summary>
        ///  Denne tager input af typen Vikingeskibe og sætter det li med selectedSkibe.
        /// </summary>
        /// <param name="s"></param>

        public void SetSelectedSkibe(Vikingeskibe s)
        {
            MainViewModel.SelectedSkibe = s;
        }
    }
}
