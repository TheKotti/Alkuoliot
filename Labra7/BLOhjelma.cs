using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    [Serializable]
    class Ohjelma
    {
        public string  Nimi { get; set; }
        public int Kanava { get; set; }
        public string Alkuaika { get; set; }
        public string Loppuaika { get; set; }
        public string Info { get; set; }

        public Ohjelma()
        {

        }

        public override string ToString()
        {
            return Nimi + " " + Kanava + " " + Alkuaika + " " + Loppuaika + " " + Info;
        }
    }
}
