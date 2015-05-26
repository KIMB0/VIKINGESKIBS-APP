using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VIKINGEdesign.Annotations;
using Windows.UI.Xaml;
using VIKINGEdesign.Common;
using VIKINGEdesign.Handler;
using VIKINGEdesign.Model;


namespace VIKINGEdesign.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private int _billetId;
        private int _kundeId;
        private int _antalBorn;
        private int _antalStuderende;
        private int _antalVoksne;
        //private DateTime _dateTime;
        private DateTimeOffset _dateTime = DateTimeOffset.Now;
        private decimal _pris;
        private bool _sejltur;
        private string _email;
        private string _navn;
        private string _telefonNr;

        
        public Billet Billet { get; set; }
        public Kunde Kunde { get; set; }
        public VikingeCatalogSingleton VikingeCatalogSingleton { get; set; }

        //public static Vikingeskib SelectedVikingeskib { get; set; }

        public Handler.PrisHandler PrisHandler { get; set; }
        public Handler.BilletHandler BilletHandler { get; set; }

        private ICommand _createBilletCommand;

        public ICommand CreateBilletCommand
        {
            get
            {
                if (_createBilletCommand == null)
                    _createBilletCommand = new RelayCommand(BilletHandler.CreateBillet);
                return _createBilletCommand;
            }
            set { _createBilletCommand = value; }
        }
        

        public MainViewModel()
        {
            VikingeCatalogSingleton = Model.VikingeCatalogSingleton.Instance;
            PrisHandler = new PrisHandler(this);
            BilletHandler = new BilletHandler(this,PrisHandler);
        }


        public int Billet_id
        {
            get { return _billetId; }
            set { _billetId = value; OnPropertyChanged(); }
        }

        public int Kunde_id
        {
            get { return _kundeId; }
            set { _kundeId = value; OnPropertyChanged(); }
           
        }

        public int AntalStuderende
        {
            get { return _antalStuderende; }
            set { _antalStuderende = value; OnPropertyChanged(); }
        }

        public int AntalBorn
        {
            get { return _antalBorn; }
            set { _antalBorn = value; OnPropertyChanged(); }
        }

        public int AntalVoksne
        {
 
            get { return _antalVoksne; }
            set { _antalVoksne = value; OnPropertyChanged(); }
        }

        public bool Sejltur
        {
            get { return _sejltur; }
            set { _sejltur = value; OnPropertyChanged(); }
        }


        public DateTimeOffset DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; OnPropertyChanged(); }
        }

        public decimal Pris
        {
            get { return _pris; }
            set { _pris = value; OnPropertyChanged(); }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        public string TelefonNr
        {
            get { return _telefonNr; }
            set { _telefonNr = value; OnPropertyChanged(); }
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
