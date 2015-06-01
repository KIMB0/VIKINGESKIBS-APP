using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGEdesign.Model
{
    class Priser
    {
        private int _prisId;
        private decimal _pris;
        private string _gruppe;
        /// <summary>
        /// Constructoren tager 3 inputs og sætter dem lig med de properties der er i denne klasse
        /// </summary>
        /// <param name="prisId">Tager en int værdi som parameter</param>
        /// <param name="pris">Tager en decimal værdi som parameter</param>
        /// <param name="gruppe">Tager en string værdi som parameter</param>
        public Priser(int prisId, decimal pris, string gruppe)
        {
            _prisId = prisId;
            _pris = pris;
            _gruppe = gruppe;
        }

        public int PrisID
        {
            get { return _prisId; }
            set { _prisId = value; }
        }

        public decimal Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public string Gruppe
        {
            get { return _gruppe; }
            set { _gruppe = value; }
        }
    }
}
