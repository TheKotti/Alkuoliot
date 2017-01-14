using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int counter = 0;
            int[] luvut = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna luku " + (counter+1));
                input = Console.ReadLine();
                if (Int32.TryParse(input, out luvut[counter]))
                {

                    counter++;
                }
            }
            Array.Reverse(luvut);
            Console.WriteLine();
            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write(luvut[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
