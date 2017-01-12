using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            float kulutus = 7.02F/100, bhinta = 1.595F, kustannus, matka, litrat;
            Console.WriteLine("Anna matka");
            string input = Console.ReadLine();
            if (float.TryParse(input, out matka))
            {
                kustannus = matka * kulutus * bhinta;
                litrat = matka * kulutus;
                Console.WriteLine("Bensaa kuluu {0} litraa, rahaa kuluu {1} euroa.", Math.Round(litrat, 2), Math.Round(kustannus,2));
            }
            else
            {
                Console.WriteLine("Virhe");
            }
        }
    }
}
