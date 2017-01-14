using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku");
            string input = Console.ReadLine();
            string space = " ";
            string star = "*";
            int numero, j = 1, k=1;

            if (Int32.TryParse(input, out numero))
            {
                //Puu
                for (int rivit = 0; rivit < numero; rivit++)
                {

                    for (int i = 0; i < (numero - k); i++)
                    {
                        Console.Write(space);
                    }
                    for (int i = 0; i < j; i++)
                    {
                        Console.Write(star);
                    }
                    for (int i = 0; i < (numero - k); i++)
                    {
                        Console.Write(space);
                    }
                    j = j + 2;
                    k = k + 1;
                    Console.WriteLine();
                }
                //Kanto
                for (int m = 0; m < 2; m++)
                {
                    
                    for (int i = 0; i < (numero - 1); i++)
                    {
                        Console.Write(space);
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write(star);
                    }
                    for (int i = 0; i < (numero - 1); i++)
                    {
                        Console.Write(space);
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
