using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGEdesign.Model
{
    class Kunde
    {
        private int _kundeId;
        private string _email;
        private string _navn;
        private int _telefonNr;

        public Kunde(string email, string navn, int telefonNr)
        {
            _email = email;
            _navn = navn;
            _telefonNr = telefonNr;
        }

        public int Kunde_id
        {
            get { return _kundeId; }
            set { _kundeId = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int TelefonNr
        {
            get { return _telefonNr; }
            set { _telefonNr = value; }
        }
    }
}
