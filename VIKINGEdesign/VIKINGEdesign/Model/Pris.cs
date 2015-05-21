using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGEdesign.Model
{
    class Pris
    {
        private double _bornPris;
        private double _voksenPris = 115;
        private double _studentPris = 100;
        private double _total;

        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public double VoksenPris
        {
            get { return _voksenPris; }
            set { _voksenPris = value; }
        }

        public double StudentPris
        {
            get { return _studentPris; }
            set { _studentPris = value; }
        }

        public double BornPris
        {
            get { return _bornPris; }
            set { _bornPris = value; }
        }


    }
}
