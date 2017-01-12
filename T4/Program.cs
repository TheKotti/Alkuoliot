using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ikä");
            string input = Console.ReadLine();
            int numero;
            if (Int32.TryParse(input, out numero))
            {
                if (numero < 18)
                {
                    Console.WriteLine("Alaikäinen");
                }
                else if (numero > 65)
                {
                    Console.WriteLine("Seniori");
                }
                else
                {
                    Console.WriteLine("Aikuinen");
                }
            }
            else
            {
                Console.WriteLine("Virhe");
            }
        }
    }
}
