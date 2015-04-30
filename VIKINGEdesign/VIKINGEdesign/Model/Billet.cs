using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGEdesign.Model
{
    class Billet
    {
        private int _billetId;
        private int _kundeId;
        private int _antalBørn;
        private int _antalVoksne;
        private bool _sejltur;
        private DateTime _dateTime;
        private int _pris;

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

        public int AntalBørn
        {
            get { return _antalBørn; }
            set { _antalBørn = value; }
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

        public int Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }
        
    }
   
}
