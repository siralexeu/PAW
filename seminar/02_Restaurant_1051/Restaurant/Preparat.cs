using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant {
    internal class Preparat {

        public Preparat(string _denumire, float _pret) {
            denumire = _denumire;
            pret = _pret;
        }

        string denumire = "Cafea";
        public string Denumire {
            get {
                return denumire;
            }
            set {
                denumire = value;
            }
        }

        float pret = 15;
        public float Pret {
            get {
                return pret;
            }
            set {
                if (value > 0) pret = value;
                else pret = 1;
            }
        }
    }
}
