using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace _2T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija[] opiskelijat = new Opiskelija[5];
            opiskelijat[0] = new Opiskelija("qwe", 120, 1.6F);
            opiskelijat[1] = new Opiskelija("asd", 50, 2.4F);
            opiskelijat[2] = new Opiskelija("zxc", 350, 0.4F);
            opiskelijat[3] = new Opiskelija("tyu", 2, 20.4F);
            opiskelijat[4] = new Opiskelija("ghj", 800, 9.4F);

            for (int i = 0; i < opiskelijat.Length; i++)
            {
                opiskelijat[i].PrintData();
            }
        }
    }
}
