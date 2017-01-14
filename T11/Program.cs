using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku");
            string input = Console.ReadLine();
            int numero;

            if (Int32.TryParse(input, out numero))
            {
                for (int i = 0; i <= numero; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Virhe");
            }
        }
    }
}
