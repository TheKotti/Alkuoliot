using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna sekunnit");
            string input = Console.ReadLine();
            int numero, tunnit, minuutit, sekunnit;
            if (Int32.TryParse(input, out numero))
            {
                tunnit = numero / 3600;
                minuutit = (numero % 3600) / 60;
                sekunnit = (numero % 3600) % 60;
                Console.WriteLine("{0} tuntia, {1} minuuttia, {2} sekuntia", tunnit, minuutit, sekunnit);
            }
            else
            {
                Console.WriteLine("Virhe");
            }
        }
    }
}
