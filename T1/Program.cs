using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku 1-3");
            string luku = Console.ReadLine();
            switch (luku)
            {
                case "1":
                    Console.WriteLine("Yksi");
                    break;
                case "2":
                    Console.WriteLine("Kaksi");
                    break;
                case "3":
                    Console.WriteLine("Kolme");
                    break;
                default:
                    Console.WriteLine("Jotain muuta");
                    break;
            }
        }
    }
}
