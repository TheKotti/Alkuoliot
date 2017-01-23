using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vehicle
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosi { get; set; }
        public string Vari { get; set; }

        public override string ToString()
        {
            return "Nimi: " + Nimi + ", Malli: " + Malli + ", Vuosi: " + Vuosi + ", Väri: " + Vari;
        }
        public Vehicle()
        {

        }
        public Vehicle (string nimi, string malli, int vuosi, string vari)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosi = vuosi;
            Vari = vari;
        }
    }
}
