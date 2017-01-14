using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna virke");
            string input = Console.ReadLine();
            char[] flipped = input.ToCharArray();
            Array.Reverse(flipped);
            string check = new string(flipped);

            if (check.Equals(input, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Palindromi");
            }
            else
            {
                Console.WriteLine("Ei palindromi");
            }
        }
    }
}
