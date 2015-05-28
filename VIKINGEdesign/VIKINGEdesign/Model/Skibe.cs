using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.Annotations;

namespace VIKINGEdesign.Model {
    public class Skibe : INotifyPropertyChanged {
    

        private string _navn;
        private string _beskrivelse;
        private string _informationer;
        private string _billede;
        public Skibe(string navn, string beskrivelse, string informationer, string billede) {
            _navn = navn;
            _beskrivelse = beskrivelse;
            _informationer = informationer;
            _billede = billede;
        }

        public string Navn {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Beskrivelse {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }


        public string Informationer {
            get { return _informationer; }
            set { _informationer = value; }
        }

        public string Billede {
            get { return _billede; }
            set { _billede = value; }
        }

        public override string ToString()
        {
            return string.Format(_navn);
        }

        #region

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
