using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14
{
    class Program
    {
        static void Main(string[] args)
        {
            int nolla = 0, yksi = 0, kaksi = 0, kolme = 0, nelja = 0, viisi = 0, i=1, luku;
            string input;

            Console.WriteLine("Anna arvosana " + i + ", lopeta kirjaimella");
            input = Console.ReadLine();
            while (Int32.TryParse(input, out luku))
            {
                switch (luku)
                {
                    case 0:
                        nolla++;
                        i++;
                        Console.WriteLine("Anna arvosana " + i);
                        input = Console.ReadLine();
                        break;
                    case 1:
                        yksi++;
                        i++;
                        Console.WriteLine("Anna arvosana " + i);
                        input = Console.ReadLine();
                        break;
                    case 2:
                        kaksi++;
                        i++;
                        Console.WriteLine("Anna arvosana " + i);
                        input = Console.ReadLine();
                        break;
                    case 3:
                        kolme++;
                        i++;
                        Console.WriteLine("Anna arvosana " + i);
                        input = Console.ReadLine();
                        break;
                    case 4:
                        nelja++;
                        i++;
                        Console.WriteLine("Anna arvosana " + i);
                        input = Console.ReadLine();
                        break;
                    case 5:
                        viisi++;
                        i++;
                        Console.WriteLine("Anna arvosana " + i);
                        input = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Anna arvosana " + i);
                        input = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("Arvosanat:");

            Console.Write("0: ");
            for (int j = 0; j < nolla; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("1: ");
            for (int j = 0; j < yksi; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("2: ");
            for (int j = 0; j < kaksi; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("3: ");
            for (int j = 0; j < kolme; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("4: ");
            for (int j = 0; j < nelja; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("5: ");
            for (int j = 0; j < viisi; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
