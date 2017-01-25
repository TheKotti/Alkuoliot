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
            //TestaaHloRekisteri();
            TestaaKortit();
        }

        static void TestaaHloRekisteri()
        {
            //luodaan muutama testihenkilö
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "123123-321A" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Qewr", Sukunimi = "qwerqwer", Hetu = "5432-33451A" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Asdf", Sukunimi = "asdfsadf", Hetu = "765456-86454G" };
            Henkilo hlo3 = new Henkilo { Etunimi = "iuyt", Sukunimi = "iuytuyi", Hetu = "111" };

            //lisätään henkilot poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);
            poppoo.LisaaHenkilo(hlo3);

            //tulostetaan poppoo
            foreach (var item in poppoo.HenkiloLista)
            {
                Console.WriteLine(item.ToString());
            }

            //thedänn hakuja
            Console.WriteLine(poppoo.HaeHenkilo(0));
            Console.WriteLine("Hae hetulla");
            Console.WriteLine(poppoo.HaeHenkiloHetulla(Console.ReadLine()));
        }
        static void TestaaKortit()
        {
            Deck pakka = new IT.Deck();

            foreach (var item in pakka.Cards)
            {
                Console.WriteLine(item.ToString());
            }
            
            pakka.Shuffle();
            foreach (var item in pakka.Cards)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
