using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Auto : Vehicle
    {
        private const int maxRenkaat = 4;
        public int RengasLkm { get; }
        public List<Rengas> Renkaat { get; }

        public Auto(string nimi, string malli, int vuosi, string vari)
                : base(nimi, malli, vuosi, vari)
        {
            Renkaat = new List<Rengas>();
        }

        public Auto()
        {
            Renkaat = new List<Rengas>();
        }

        public void LisaaRengas (Rengas rengas, int lkm)
        {
            if (maxRenkaat >= lkm)
            {
                for (int i = 0; i < lkm; i++)
                {
                    Renkaat.Add(rengas);
                }
            }
            else
            {
                for (int i = 0; i < maxRenkaat; i++)
                {
                    Renkaat.Add(rengas);
                }
            }
        }
        public override string ToString()
        {
            return base.ToString() + ", Renkaat: " + Renkaat.Count + ", Tyyppi: " + Renkaat[0];
        }

    }
}
