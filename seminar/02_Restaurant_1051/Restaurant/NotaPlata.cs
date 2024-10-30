using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant {
    internal class NotaPlata {
        public int idMasaAchita=0;
        public List<Comanda> lstComenziMasa=new List<Comanda>();
        public double TotalNota { get => lstComenziMasa.Sum(x => x.Valoare); }
        
    }
}
