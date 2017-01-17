using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT; //helpotta meidän luokkien löytämistä

namespace _2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestaaKiuas();
            //TestaaPesukone();
            //TestaaTV();
            TestaaVehicle();
        }

        //T1 Kiuas-luokan testaus
        static void TestaaKiuas()
        {
            //luodaan Kiuas-olio
            Kiuas kiuas = new Kiuas();

            //laitetaan lämpiämään ja lämpöä ja kosteutta
            kiuas.OnkoPaalla = true;
            kiuas.Lampotila = 90;
            kiuas.Kosteus = 50;

            //näytetään konsolilla
            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPaalla);
            Console.WriteLine("Lämpötila on {0}", kiuas.Lampotila);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);

            //liikaa kosteutta
            kiuas.Kosteus = 150;
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
        }
        static void TestaaPesukone()
        {
            //luodaan Pesukone-olio
            Pesukone kone = new Pesukone();

            //laitetaan lämpiämään ja lämpöä ja kosteutta
            kone.SaakoVirtaa = true;
            kone.SaakoVetta = true;
            kone.OnkoPaalla = true;

            //näytetään konsolilla
            Console.WriteLine("Pesukone saa virtaa {0}", kone.OnkoPaalla);
            Console.WriteLine("Pesukone saa vettä {0}", kone.SaakoVetta);
            Console.WriteLine("Pesukone on päällä {0}", kone.OnkoPaalla);
        }
        static void TestaaTV()
        {
            TV telkkari = new JAMK.IT.TV();

            telkkari.OnkoPaalla = true;
            telkkari.Volume = 99;
            telkkari.Kanava = 59;

            Console.WriteLine("päällä {0}", telkkari.OnkoPaalla);
            Console.WriteLine("volume {0}", telkkari.Volume);
            Console.WriteLine("kanava {0}", telkkari.Kanava);
            telkkari.Kanava = -5;
            telkkari.Volume = 999;
            Console.WriteLine("volume {0}", telkkari.Volume);
            Console.WriteLine("kanava {0}", telkkari.Kanava);
        }
        static void TestaaVehicle()
        {
            Vehicle auto = new Vehicle();
            auto.Name = "autoooo";
            auto.Speed = 20;
            auto.Tyres = 3;
            auto.PrintData();
            Console.WriteLine(auto.ToString());
        }
    }
}
