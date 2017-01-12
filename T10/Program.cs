using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arvot = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < arvot.Length; i++)
            {
                Console.Write(arvot[i] + " ");
                if (arvot[i]%2 == 0)
                {
                    Console.Write("HEP");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
