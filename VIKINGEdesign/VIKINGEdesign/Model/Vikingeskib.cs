using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGEdesign.Model
{
    class Vikingeskib
    {
        private int _skibsId;
        private string _navn;
        private int _pladser;



        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public int Pladser
        {
            get { return _pladser; }
            set { _pladser = value; }
        }


        public int Skibs_id
        {
            get { return _skibsId; }
            set { _skibsId = value; }
        }
    }
}
