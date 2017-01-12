using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna pistemäärä");
            string input = Console.ReadLine();
            int numero;
            if (Int32.TryParse(input, out numero))
            {
                if (numero < 0)
                {
                    Console.WriteLine("Virhe, liian vähän pisteitä");
                }
                else if (numero < 2)
                {
                    Console.WriteLine("Arvosana 0");
                }
                else if (numero < 4)
                {
                    Console.WriteLine("Arvosana 1");
                }
                else if (numero < 6)
                {
                    Console.WriteLine("Arvosana 2");
                }
                else if (numero < 8)
                {
                    Console.WriteLine("Arvosana 3");
                }
                else if (numero < 10)
                {
                    Console.WriteLine("Arvosana 4");
                }
                else if (numero < 13)
                {
                    Console.WriteLine("Arvosana 5");
                }
                else
                {
                    Console.WriteLine("Virhe, liikaa pisteitä");
                }
            }
            else
            {
                Console.WriteLine("Virhe, ei numero");
            }
        }
    }
}
