using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna vuosi");
            string input = Console.ReadLine();
            int numero;

            if (Int32.TryParse(input, out numero))
            {
                if (numero%400 == 0)
                {
                    Console.WriteLine("Karkausvuosi");
                }
                else if (numero % 100 == 0)
                {
                    Console.WriteLine("Ei karkausvuosi");
                }
                else if (numero % 4 == 0)
                {
                    Console.WriteLine("Karkausvuosi");
                }
                else
                {
                    Console.WriteLine("Ei karkausvuosi");
                }
            }
            else
            {
                Console.WriteLine("Virhe");
            }
        }
    }
}
