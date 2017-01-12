using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int i = 1, luku, summa = 0;

            do
            {
                Console.WriteLine("Anna luku " + i);
                temp = Console.ReadLine();
                Int32.TryParse(temp, out luku);
                summa += luku;
                i++;
            } while (luku != 0);

            Console.WriteLine("Summa: " + summa);
        }
    }
}
