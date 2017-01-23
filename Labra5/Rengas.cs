using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Rengas
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string RengasKoko { get; set; }

        public Rengas()
        {

        }
        public Rengas(string valm, string malli, string koko)
        {
            Valmistaja = valm;
            Malli = malli;
            RengasKoko = koko;
        }

        public override string ToString()
        {
            return Valmistaja + ", " + Malli + ", " + RengasKoko;
        }
    }
}
