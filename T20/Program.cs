using System;
using System.Diagnostics;
using System.Threading;

namespace T20
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rndTime = new Random();
            int pauseTime = rndTime.Next(2500, 9001);
            ConsoleKeyInfo input;
            bool written = false;
            Stopwatch kello = new Stopwatch();
            Stopwatch endTimer = new Stopwatch();
            Thread.Sleep(1);

            Console.WriteLine("Kahden pelaajan reaktiotesti");
            Console.WriteLine();
            Console.WriteLine("Paina näppäintä sanan 'NYT' ilmestyessä");
            Console.WriteLine("Pelaaja Q, näppäimesi on Q");
            Console.WriteLine("Pelaaja P, näppäimesi on P");
            Console.WriteLine();
            Console.WriteLine("Paina välilyöntiä aloittaaksesi, jotain muuta lopettaaksesi");
            Console.WriteLine();

            
            input = Console.ReadKey(true);
            if (Convert.ToString((input.Key)) == "Spacebar")
            {
                kello.Start();

                //käsittelee aikaset painallukset
                while (pauseTime > kello.ElapsedMilliseconds)
                {
                    if (Console.KeyAvailable == true)
                    {
                        input = Console.ReadKey(true);

                        if (Convert.ToString((input.Key)) == "Q" && endTimer.ElapsedMilliseconds == 0)
                        {
                            Console.WriteLine("Pelaaja P voitti!");
                            Console.WriteLine("Pelaaja Q painoi nappia {0}ms liian aikaisin.", (pauseTime - kello.ElapsedMilliseconds));
                            Console.WriteLine();
                            endTimer.Start();
                        }
                        else if (Convert.ToString((input.Key)) == "P" && endTimer.ElapsedMilliseconds == 0)
                        {
                            Console.WriteLine("Pelaaja Q voitti!");
                            Console.WriteLine("Pelaaja P painoi nappia {0}ms liian aikaisin.", (pauseTime - kello.ElapsedMilliseconds));
                            Console.WriteLine();
                            endTimer.Start();
                        }
                    }
                }

                //printtaa NYT
                while (written == false && endTimer.ElapsedMilliseconds == 0)
                {
                    if (pauseTime <= kello.ElapsedMilliseconds && written == false)
                    {
                        Console.WriteLine("NYT");
                        Console.WriteLine();
                        written = true;
                    }
                }


                //käsittelee myöhäiset painallukset
                while (endTimer.ElapsedMilliseconds == 0)
                {
                    if (Console.KeyAvailable == false)
                    {
                        input = Console.ReadKey(true);

                        if (Convert.ToString((input.Key)) == "Q" && endTimer.ElapsedMilliseconds == 0)
                        {
                            Console.WriteLine("Pelaaja Q voitti!");
                            Console.WriteLine("Reaktioaika: " + (kello.ElapsedMilliseconds - pauseTime) + "ms");
                            Console.WriteLine();
                            endTimer.Start();
                        }
                        else if (Convert.ToString((input.Key)) == "P" && endTimer.ElapsedMilliseconds == 0)
                        {
                            Console.WriteLine("Pelaaja P voitti!");
                            Console.WriteLine("Reaktioaika: " + (kello.ElapsedMilliseconds - pauseTime) + "ms");
                            Console.WriteLine();
                            endTimer.Start();
                        }
                    }

                    while (true)
                    {
                        if (endTimer.ElapsedMilliseconds > 1000)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            } 
        }
    }
}
