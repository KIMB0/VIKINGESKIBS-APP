using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.Annotations;
using Windows.UI.Xaml;
using VIKINGEdesign.Model;


namespace VIKINGEdesign.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {

        public VikingeCatalogSingleton VikingeCatalogSingleton { get; set; }
        public static Vikingeskib SelectedVikingeskib { get; set; }

        public MainViewModel()
        {
            VikingeCatalogSingleton = Model.VikingeCatalogSingleton.Instance;
        }


        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
