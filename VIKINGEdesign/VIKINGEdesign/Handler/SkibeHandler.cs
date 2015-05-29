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

        public SkibeHandler(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }
        public void SetSelectedSkibe(Vikingeskibe s)
        {
            MainViewModel.SelectedSkibe = s;
        }
    }
}
