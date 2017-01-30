using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Teht3();
        }

        static void Teht1()
        {
            try { 
            List<string> nimet = new List<string>();
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\K8721\ConsoleApplication2\Labra7\test.txt", true);
            string temp = "";
                while (temp != "0")
                {
                    Console.WriteLine("Anna nimi, 0 lopettaa");
                    temp = Console.ReadLine();
                    if (temp != "0")
                    {
                        outputFile.WriteLine(temp);
                    }
                    else
                    {
                        outputFile.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Teht2()
        {
            try
            {
                Console.WriteLine(System.IO.File.Exists(@"d:\K8721\ConsoleApplication2\Labra7\test.txt") ? "Tiedosto on olemassa." : "Tiedostoa ei ole olemassa.");
                if (System.IO.File.Exists(@"d:\K8721\ConsoleApplication2\Labra7\test.txt")) {
                    string[] lines = System.IO.File.ReadAllLines(@"d:\K8721\ConsoleApplication2\Labra7\test.txt");
                    Console.WriteLine("Yhteensä {0} riviä ja {1} nimeä", lines.Length, lines.Distinct().Count());
                    Array.Sort(lines);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Teht3()
        {
            try
            {
                List<int> intit = new List<int>();
                List<float> floatit = new List<float>();
                int conversion = 0;
                float conversion2 = 0.0F;
                string path = @"d:\K8721\ConsoleApplication2\Labra7", temp;

                
                do
                {
                    Console.WriteLine("Anna int tai float, kaikki muu lopettaa");
                    temp = Console.ReadLine();
                    if (int.TryParse(temp, out conversion))
                    {
                        string intfile = path + @"\intfile.txt";
                        System.IO.StreamWriter outputFile = new System.IO.StreamWriter(intfile, true);
                        outputFile.WriteLine(conversion);
                        outputFile.Close();
                    }
                    else if (float.TryParse(temp, out conversion2)) {
                        string floafile = path + @"\floatfile.txt";
                        System.IO.StreamWriter outputFile = new System.IO.StreamWriter(floafile, true);
                        outputFile.WriteLine(conversion2);
                        outputFile.Close();
                    }
                } while (Single.TryParse(temp, out conversion2) || Int32.TryParse(temp, out conversion));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
