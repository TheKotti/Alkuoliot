using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                T3();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void T1()
        {
            try
            {
                Noppa noppa = new Noppa();
                List<int> heitot = new List<int>();
                Console.WriteLine("Montako kertaa heitetään?");
                int heittocount = int.Parse(Console.ReadLine());
                for (int i = 0; i < heittocount; i++)
                {
                    heitot.Add(noppa.Throw());
                }
                Console.WriteLine(heitot.Average());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        static void T2()
        {
            try
            {
                List<Product> karry = new List<Product>();
                int input;
                Product olut = new Product { Name = "Beer", Price = 1.2F };
                Product makkara = new Product { Name = "Sausage", Price = 2.1F };

                Console.WriteLine("1. Lisää olutta");
                Console.WriteLine("2. Lisää makkaraa");
                Console.WriteLine("3. Poista olutta");
                Console.WriteLine("4. Poista makkaraa");
                int.TryParse(Console.ReadLine(), out input);
                while (0 < input && input < 5)
                {
                    switch (input)
                    {
                        case 1:
                            {
                                karry.Add(olut);
                                break;
                            }
                        case 2:
                            {
                                karry.Add(makkara);
                                break;
                            }
                        case 3:
                            {
                                if (karry.Contains(olut))
                                {
                                    karry.Remove(olut);
                                }
                                break;
                            }
                        case 4:
                            {
                                if (karry.Contains(makkara))
                                {
                                    karry.Remove(makkara);
                                }
                                break;
                            }
                        default:
                            break;
                    }
                    int.TryParse(Console.ReadLine(), out input);
                }
                for (int i = 0; i < karry.Count(); i++)
                {
                    Console.WriteLine(karry[i].ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        static void T3()
        {
            Place meri = new Place { Nimi = "Meri", Paikka = "Kaukana" };
            Place jarvi = new Place { Nimi = "Jarvi", Paikka = "Lähellä" };
            Fish hauki = new IT.Fish { Laji = "Hauki", Paino = 4.1F, Pituus = 32.1F, SaantiPaikka = jarvi };
            Fish sarki = new IT.Fish { Laji = "Särki", Paino = 8.3F, Pituus = 3.5F, SaantiPaikka = jarvi };
            Fish delfiini = new IT.Fish { Laji = "Tonnikala", Paino = 150.5F, Pituus = 320.1F, SaantiPaikka = meri };
            Fisher rami = new Fisher { Nimi = "Rami", PuhNro = "1234567890" };

            Console.WriteLine("Kalapaikat:");
            Console.WriteLine(meri.ToString());
            Console.WriteLine(jarvi.ToString());

            Console.WriteLine("\nKalastaja:");
            Console.WriteLine("- Nimi: " + rami.Nimi);
            Console.WriteLine("- Puhelinnumero: " + rami.PuhNro);
            Console.WriteLine("- Kalat:");
            for (int i = 0; i < rami.KalaLista.Count; i++)
            {
                Console.WriteLine("  - " + rami.KalaLista.ElementAt(i).ToString());
            }

            Console.WriteLine("\n" + rami.LisaaKala(hauki));
            Console.WriteLine(rami.LisaaKala(sarki));
            Console.WriteLine(rami.LisaaKala(delfiini));

            Console.WriteLine("\nKalastaja:");
            Console.WriteLine("- Nimi: " + rami.Nimi);
            Console.WriteLine("- Puhelinnumero: " + rami.PuhNro);
            Console.WriteLine("- Kalat:");
            for (int i = 0; i < rami.KalaLista.Count; i++)
            {
                Console.WriteLine("  - " + rami.KalaLista.ElementAt(i).ToString());
            }

        }
    }
}
