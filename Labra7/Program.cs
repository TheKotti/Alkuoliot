using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
                } while (float.TryParse(temp, out conversion2) || int.TryParse(temp, out conversion));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Teht4()
        {
            try
            {
                int valinta;
                List<Ohjelma> ohjelmat = new List<Ohjelma>();
                IFormatter formatter = new BinaryFormatter();

                Console.WriteLine("(1) Luo tv-ohjelmat pääohjelmalla");
                Console.WriteLine("(2) Hae tv-ohjelmat tiedostosta");
                Console.WriteLine("(Muu) lopeta");
                int.TryParse(Console.ReadLine(), out valinta);
                if (valinta == 1)
                {
                    ohjelmat.Add(new Ohjelma { Nimi = "Band of Brothers", Kanava = 3, Alkuaika = "22:00", Loppuaika = "23:00", Info = "Tässä soditaan" });
                    ohjelmat.Add(new Ohjelma { Nimi = "Stargate", Kanava = 8, Alkuaika = "21:00", Loppuaika = "21:55", Info = "Tässä soditaan avaruudessa" });
                    ohjelmat.Add(new Ohjelma { Nimi = "Twin Peaks", Kanava = 1, Alkuaika = "12:00", Loppuaika = "15:00", Info = "Mitäköhän hittoa" });
                    ohjelmat.Add(new Ohjelma { Nimi = "Lost", Kanava = 6, Alkuaika = "19:00", Loppuaika = "20:00", Info = "Tämä on tosi huono" });

                    for (int i = 0; i < ohjelmat.Count; i++)
                    {
                        Console.WriteLine(ohjelmat[i].ToString());
                    }

                    Stream tallennaStream = new FileStream("ohjelmat.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(tallennaStream, ohjelmat);
                    tallennaStream.Close();
                }
                else if (valinta == 2)
                {
                    Stream avaaStream = new FileStream("ohjelmat.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                    ohjelmat = (List<Ohjelma>)formatter.Deserialize(avaaStream);
                    for (int i = 0; i < ohjelmat.Count; i++)
                    {
                        Console.WriteLine(ohjelmat[i].ToString());
                    }
                    avaaStream.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
