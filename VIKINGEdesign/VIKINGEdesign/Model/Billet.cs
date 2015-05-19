using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.Annotations;

namespace VIKINGEdesign.Model
{
    class Billet : INotifyPropertyChanged
    {
        private int _billetId;
        private int _kundeId;
        private int _antalBorn;
        private int _antalStuderende;
        private int _antalVoksne;
        private DateTime _dateTime;
        private double _pris;
        private bool _sejltur;

        public Billet(int antalBorn, int antalStuderende, int antalVoksne, DateTime dateTime, double pris, bool sejltur)
        {
            _antalBorn = antalBorn;
            _antalStuderende = antalStuderende;
            _antalVoksne = antalVoksne;
            _dateTime = dateTime;
            _pris = pris;
            _sejltur = sejltur;
        }

        public int Billet_id
        {
            get { return _billetId; }
            set { _billetId = value; }
        }

        public int Kunde_id
        {
            get { return _kundeId; }
            set { _kundeId = value; }
        }

        public int AntalStuderende
        {
            get { return _antalStuderende; }
            set { _antalStuderende = value; }
        }

        public int AntalBorn
        {
            get { return _antalBorn; }
            set { _antalBorn = value; }
        }

        public int AntalVoksne
        {
            get { return _antalVoksne; }
            set { _antalVoksne = value; }
        }

        public bool Sejltur
        {
            get { return _sejltur; }
            set { _sejltur = value; }
        }
        

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        #region INotifyPropertyChanged

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
