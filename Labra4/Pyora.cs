using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pyora : Vehicle
    {
        public bool OnkoVaihteet { get; set; }
        public string Vaihteet { get; set; }

        
        public Pyora()
        {

        }
        public Pyora(string nimi, string malli, int vuosi, string vari, bool onkovaihteet)
                : base(nimi, malli, vuosi, vari)
        {
            OnkoVaihteet = onkovaihteet;
        }
        public Pyora(string nimi, string malli, int vuosi, string vari, bool onkovaihteet, string vaihteet)
                : base(nimi, malli, vuosi, vari)
        {
            OnkoVaihteet = onkovaihteet;
            Vaihteet = vaihteet;
        }
        public override string ToString()
        {
            if (OnkoVaihteet == true)
                return base.ToString() + ", Vaihteet: " + Vaihteet;
            else
                return base.ToString() + ", Vaihteet: Ei ole";
        }
    }
}
