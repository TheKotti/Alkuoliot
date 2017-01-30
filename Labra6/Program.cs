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
            //TestaaCD();
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

            Console.WriteLine("\nPakka on sekoitettu\n");
            foreach (var item in pakka.Cards)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void TestaaCD()
        {
            CD slaughter = new IT.CD { Title = "Slaughter of the Soul", Artist = "At the Gates" };
            Song bbf = new Song { Title = "Blinded By Fear", Length = "3:12" };
            Song sots = new Song { Title = "Slaughter of the Soul", Length = "3:02" };
            Song cold = new Song { Title = "Cold", Length = "3:28" };
            Song utss = new Song { Title = "Under the Serpent Sun", Length = "39:58" };
            Song itds = new Song { Title = "Into the Dead Sky", Length = "55:12" };
            slaughter.AddSong(bbf);
            slaughter.AddSong(sots);
            slaughter.AddSong(cold);
            slaughter.AddSong(utss);
            slaughter.AddSong(itds);
            slaughter.AlbumInfoConsole();
            Console.WriteLine();
            CD oceanMachine = new IT.CD { Title = "Ocean Machine", Artist = "Devin Townsend" };
            Song sw = new Song { Title = "Seventh Wave", Length = "6:50" };
            Song life = new Song { Title = "Life", Length = "4:31" };
            Song night = new Song { Title = "Night", Length = "4:45" };
            Song hn = new Song { Title = "Hide Nowhere", Length = "5:00" };
            oceanMachine.AddSong(sw);
            oceanMachine.AddSong(life);
            oceanMachine.AddSong(night);
            oceanMachine.AddSong(hn);
            oceanMachine.AlbumInfoConsole();
            Console.WriteLine(oceanMachine.CountLength());


        }
    }
}
