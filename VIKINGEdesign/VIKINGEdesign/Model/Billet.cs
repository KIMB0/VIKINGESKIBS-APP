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
        private decimal _pris;
        private bool _sejltur;
        /// <summary>
        /// Constructoren tager 7 inputs og sætter dem lig med de properties der er i denne klasse
        /// </summary>
        /// <param name="kundeId">Tager en int værdi som parameter</param>
        /// <param name="antalBorn">Tager en int værdi som parameter</param>
        /// <param name="antalStuderende">Tager en int værdi som parameter</param>
        /// <param name="antalVoksne">Tager en int værdi som parameter</param>
        /// <param name="dateTime">Tager en DateTime værdi som parameter</param>
        /// <param name="pris">Tager en decimal værdi som parameter</param>
        /// <param name="sejltur">Tager en bool værdi som parameter</param>
        public Billet(int kundeId,int antalBorn, int antalStuderende, int antalVoksne, DateTime dateTime, decimal pris, bool sejltur)
        {
            _kundeId = kundeId;
            _antalBorn = antalBorn;
            _antalStuderende = antalStuderende;
            _antalVoksne = antalVoksne;
            _dateTime = dateTime;
            _pris = pris;
            _sejltur = sejltur;
        }

        public int BilletID
        {
            get { return _billetId; }
            set { _billetId = value; }
        }

        public int KundeID
        {
            get { return _kundeId; }
            set { _kundeId = value; }
        }

        public int AntalSuderende
        {
            get { return _antalStuderende; }
            set { _antalStuderende = value; }
        }

        public int AntalBorn
        {
            get { return _antalBorn; }
            set { _antalBorn = value; }
        }

        public int AntalVoksen
        {
            get { return _antalVoksne; }
            set { _antalVoksne = value; }
        }

        public bool Sejltur
        {
            get { return _sejltur; }
            set { _sejltur = value; }
        }


        public DateTime Dato
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public decimal Pris
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
