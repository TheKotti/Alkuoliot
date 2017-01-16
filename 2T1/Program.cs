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
            TestaaPesukone();
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
            kone.Lampotila = 90;
            kone.Kosteus = 50;

            //näytetään konsolilla
            Console.WriteLine("Pesukone on päällä {0}", );
            Console.WriteLine("Lämpötila on {0}", );
            Console.WriteLine("Pesukone kosteus {0}", );

            //liikaa kosteutta
            kone.Kosteus = 150;
            Console.WriteLine("Pesukoneen kosteus {0}", );
        }
    }
}
