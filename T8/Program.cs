using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[3];
            string temp;
            int j;

            for (int i = 0; i < luvut.Length; i++)
            {
                j = i + 1;
                Console.WriteLine("Anna luku " + j);
                temp = Console.ReadLine();
                Int32.TryParse(temp, out luvut[i]);
            }
            Array.Sort(luvut);
            Console.WriteLine("Suurin luku: " + luvut[2]);
        }
    }
}
