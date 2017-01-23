/* 
 * \\ghost\temp\TTOS0200
 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 Modified: 23.1.2017
 * Authors: Pasi Manninen, Esa Salmikangas
 */
using System;
using System.Collections.Generic;

namespace JAMK.IT
{
    /// <summary> 
    /// This class demonstrates Vehicle and Tyre classes. OOP learning.
    /// </summary>
	   class Rengas
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string Rengaskoko { get; set; }

        public override string ToString()
        {
            return "Valmistaja: " + Valmistaja + " Malli:" + Malli + " rengas koko:" + Rengaskoko;
        }
    }
	class Auto 
	{
        public string Nimi { get; set; }
        public string Malli { get; set; }
        private const int maxRenkaat = 4;
        private int lkmRenkaat = 0;
		
        public List<Rengas> Renkaat { get; }

        public Auto()
        {
            Renkaat = new List<Rengas>();
        }

        public void LisääRengas(Rengas rengas)
        {
            if (lkmRenkaat < maxRenkaat)
            {
                Renkaat.Add(rengas);
                lkmRenkaat++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", rengas.Malli, Nimi);
            } else
            {
                Console.WriteLine("No room for a new tyres..., sorry!");
            }
        }

        public override string ToString()
        {
            string s = "Pirssissä: " + Nimi + " malli :" + Malli + "\nrenkaat:";
            foreach(Rengas r in Renkaat)
            {
                if (r !=null) s += "\n-"+r.ToString();
            }
            return s;
        }
    	
	}
    class Program
    {
        static void Main(string[] args)
        {
			TestCarWithFourWheelsV2();
		}
		
		static void TestCarWithFourWheelsV2()
		{
            // create tyre
            Rengas tyre1 = new Rengas { Valmistaja = "Nokia", Malli = "Hakkapeliitta", Rengaskoko = "205R16" };
            // create a car
            Auto kaara = new Auto { Nimi = "Porsche", Malli = "911" };
            Console.WriteLine("Luotu uusi pirssi {0} {1}", kaara.Nimi, kaara.Malli);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            Console.WriteLine(kaara.ToString());
		}

    }
}
