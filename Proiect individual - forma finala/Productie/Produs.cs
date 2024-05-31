using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productie
{
    [Serializable]
    public class Produs
    {
        public string Nume { get; set; }
        public int LotFabricatie { get; set; }
        public DateTime FisaConsum { get; set; }

        public Produs(string nume = "Fara nume", int lotFabricatie = 0, DateTime fisaConsum = new DateTime())
        {
            this.Nume = nume;
            this.LotFabricatie = lotFabricatie;
            this.FisaConsum = fisaConsum == default ? DateTime.Now : fisaConsum;
        }

        public static Produs operator +(Produs produs, int cantitate)
        {
            produs.LotFabricatie += cantitate;
            return produs;
        }

        public Produs(Produs src)
        {
            this.Nume = src.Nume;
            this.LotFabricatie = src.LotFabricatie;
            this.FisaConsum = src.FisaConsum;
        }

        public override string ToString()
        {
            return $"{Nume}, Lot Fabricatie {LotFabricatie}, Data Consum {FisaConsum.ToShortDateString()}";
        }
    }
}
