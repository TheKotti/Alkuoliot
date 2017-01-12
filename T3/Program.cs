using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[3];
            string temp;
            int j, sum, avg;

            for (int i = 0; i < luvut.Length; i++)
            {
                j = i + 1;
                Console.WriteLine("Anna luku " + j);
                temp = Console.ReadLine();
                Int32.TryParse(temp, out luvut[i]);
            }
            sum = luvut[0] + luvut[1] + luvut[2];
            avg = (luvut[0] + luvut[1] + luvut[2])/3;
            Console.WriteLine("Summa: " + sum);
            Console.WriteLine("Keskiarvo: " + avg);
        }
    }
}
