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
        private string _telefon;
        /// <summary>
        /// Constructoren tager 3 inputs og sætter dem lig med de properties der er i denne klasse
        /// </summary>
        /// <param name="email">Tager en string værdi som parameter</param>
        /// <param name="navn">Tager en string værdi som parameter</param>
        /// <param name="telefon">Tager en string værdi som parameter</param>
        public Kunde(string email, string navn, string telefon)
        {
            _email = email;
            _navn = navn;
            _telefon = telefon;
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

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
    }
}
