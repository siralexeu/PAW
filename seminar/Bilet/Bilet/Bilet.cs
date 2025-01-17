using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bilet
{
    interface ICalculEficienta
    {
        float pretPerKm();
    }
    [Serializable] 
    internal class Bilet : ICalculEficienta
    {
        public string Id { get; set; } = "0";
        public static int nrBilete = 0;
        public DateTime dataCursei = new DateTime();
        public string statiePlecare = "Bucuresti";
        public string destinatie = "Ploiesti";
        public double pret = 100;

        public double Pret { get=>pret; set => pret = value; }

        public Bilet(DateTime _data = new DateTime(), string _statie = "Bucuresti", string _destinatie = "Ploiesti", double _pret = 0)
        {
            nrBilete++;
            Id = nrBilete.ToString();
            this.dataCursei = _data;
            this.statiePlecare = _statie;
            this.destinatie = _destinatie;
            this.pret = _pret;
        }
        public override string ToString()
        {
            return $"{Id} de la {statiePlecare} pana la {destinatie} cost {pret} lei";
        }

        public float pretPerKm()
        {
            return (float)pret / 100;
        }
    }
    
}
