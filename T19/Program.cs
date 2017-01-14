using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19
{
    class Program
    {
        static void Main(string[] args)
        {
            string sana = "Jotain tosi luovaa";
            char[] arvattava = sana.ToCharArray();
            char[] arvatut = new char[30];
            arvatut[0] = 't';
            arvatut[1] = 'a';
            int ind = 0;



            for (int i = 0; i < arvattava.Length; i++)
            {
                if (arvattava[i] == arvatut[ind])
                {
                    Console.Write(arvattava[i]);
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine();

        }
    }
}
