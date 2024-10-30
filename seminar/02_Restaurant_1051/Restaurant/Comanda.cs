using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant {
    internal class Comanda {

        public Comanda(int idMasa, Preparat preparat, int cant) {
            IdMasa = idMasa; Preparat = preparat; Cant = cant;
        }

        public int IdMasa { get; set; }
        public Preparat Preparat { get; set; }
        public int Cant {  get; set; }
        public double Valoare { get => Cant * Preparat.Pret; }

    }
}
