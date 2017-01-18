using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vene : Vehicle
    {
        public string Tyyppi { get; set; }
        public int Istuin { get; set; }

        
        public Vene()
        {

        }
        public Vene(string nimi, string malli, int vuosi, string vari, string tyyppi, int istuin)
                : base(nimi, malli, vuosi, vari)
        {
            Tyyppi = tyyppi;
            Istuin = istuin;
        }
        public override string ToString()
        {
            return base.ToString() + ", Tyyppi: " + Tyyppi + ", Istuimia: " + Istuin;
        }
    }
}
