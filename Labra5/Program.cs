using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Rengas rengas1 = new IT.Rengas("Nokia", "Hakkapeliita", "XYZ123");
            Auto auto1 = new IT.Auto("Porsche", "911", 2014, "Vihreä");
            auto1.LisaaRengas(rengas1, 5);
            Console.WriteLine(rengas1.ToString());
            Console.WriteLine(auto1.ToString());

        }
    }
}
