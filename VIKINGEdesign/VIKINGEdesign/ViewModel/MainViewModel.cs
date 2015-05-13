using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using VIKINGEdesign.Annotations;
=======
using Windows.UI.Xaml;
>>>>>>> origin/master

namespace VIKINGEdesign.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
<<<<<<< HEAD




        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

=======
        
>>>>>>> origin/master
    }
}
