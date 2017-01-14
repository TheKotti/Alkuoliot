using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arvattava = rnd.Next(1, 101);
            Console.WriteLine("Arvaa luku");
            string input = Console.ReadLine();
            int numero, arvaukset = 0;

            do
            {
                if (Int32.TryParse(input, out numero))
                {
                    if (numero < arvattava)
                    {
                        Console.WriteLine("Luku on suurempi");
                        arvaukset++;
                        Console.WriteLine("Arvaa luku");
                        input = Console.ReadLine();
                    }
                    else if (numero > arvattava)
                    {
                        Console.WriteLine("Luku on pienempi");
                        arvaukset++;
                        Console.WriteLine("Arvaa luku");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Arvasit oikein!");
                        arvaukset++;
                        Console.WriteLine("Tarvitsit {0} yritystä", arvaukset);
                    }
                }
                else
                {
                    Console.WriteLine("Virhe");
                }
            } while (numero != arvattava);
        }
    }
}
