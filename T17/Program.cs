using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tau1 = new int[] { 10, 20, 30, 40, 50 };
            int[] tau2 = new int[] { 5, 15, 25, 35, 45 };
            int[] tau3 = new int[10];

            Array.Copy(tau1, tau3, tau1.Length);
            Array.Copy(tau2, 0, tau3, tau1.Length, tau2.Length);
            Array.Sort(tau3);

            for (int i = 0; i < tau3.Length; i++)
            {
                Console.Write(tau3[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
