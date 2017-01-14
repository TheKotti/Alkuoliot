using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int counter = 0, j = 1, sum;
            int[] luvut = new int[5], luvut2 = new int[3];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna pistemäärä " + (counter + 1));
                input = Console.ReadLine();
                if (Int32.TryParse(input, out luvut[counter]))
                {
                    counter++;
                }
            }
            Array.Sort(luvut);

            for (int i = 0; i < luvut2.Length; i++)
            {
                luvut2[i] = luvut[j];
                j++;
            }

            sum = luvut2[0] + luvut2[1] + luvut2[2];
            Console.WriteLine();
            Console.WriteLine("Yhteispisteet: " + sum);
        }
    }
}
