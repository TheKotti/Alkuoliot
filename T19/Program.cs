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
            string[] randomSanat = new string[5] { "jotain tosi luovaa", "lorem ipsum", "en jaksa keksiä mitään", "tämä on hirsipuu", "satunnainen teksti"};
            Random rnd = new Random();

            string sana = randomSanat[rnd.Next(0, randomSanat.Length)];
            char[] arvattava = sana.ToCharArray();
            char[] arvatut = new char[10];
            arvatut[0] = ' ';
            int ind = 1;
            bool written = true;
            string finalArvaus;
            char tempKirjain;

            Console.WriteLine("Hirsipuu - Arvaa teksti antamalla pieni kirjain");

            do
            {
                Console.WriteLine("Kirjain {0}, arvauksia jäljellä {1}", ind, (10-ind));
                if (Char.TryParse(Console.ReadLine(), out tempKirjain))
                {
                    if (Array.IndexOf(arvatut, tempKirjain) > -1)
                    {
                        Console.WriteLine("Olet jo arvannut tämä kirjaimen");
                    }
                    else
                    {
                        arvatut[ind] = tempKirjain;
                        ind++;
                        for (int i = 0; i < arvattava.Length; i++)
                        {

                            foreach (var kirjain in arvatut)
                            {
                                if (arvattava[i] == kirjain)
                                {
                                    Console.Write(arvattava[i]);
                                    written = true;
                                }
                            }
                            if (written == false)
                            {
                                Console.Write("_");
                                written = true;
                            }
                            written = false;
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    } 
                }
                else
                {
                    Console.WriteLine("Kirjain ei kelpaa");
                }
            } while (ind < 10);

            Console.WriteLine("Kirjaimet käytetty, arvaa teksti");
            finalArvaus = Console.ReadLine();
            Console.WriteLine();
            if (finalArvaus == sana)
            {
                Console.WriteLine("Voitit pelin");
            }
            else
            {
                Console.WriteLine("Hävisit pelin");
            }
        }
    }
}
