using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Labra4
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestaaHissi();
            //TestaaVahvistin();
            //TestaaEmployee();
            TestaaVehicle();
        }
        static void TestaaHissi()
        {
            Hissi hissi = new Hissi();
            hissi.CurrentFloor = 1;
            string input;
            int temp;

            Console.WriteLine("Hissi on kerroksessa " + hissi.CurrentFloor);

            while (hissi.CurrentFloor != 0)
            {
                Console.WriteLine("Anna kerros");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out temp))
                {
                    hissi.CurrentFloor = temp;
                    if (hissi.CurrentFloor < 6 && hissi.CurrentFloor > 0)
                    {
                        Console.WriteLine("Hissi on kerroksessa " + hissi.CurrentFloor);
                    }
                    else if (hissi.CurrentFloor == 0)
                    {
                        Console.WriteLine("kiitos kun käytit hissiä");
                    }
                }
                else
                {
                    Console.WriteLine("Virhe");
                }
            }
        }
        static void TestaaVahvistin()
        {
            Vahvistin vahvari = new Vahvistin();
            vahvari.Volume = 0;
            string input;
            int temp;

            Console.WriteLine("Vahvistimen äänenvoimakkuus on " + vahvari.Volume);

            while (true)
            {
                Console.WriteLine("Aseta äänenvoimakkuus");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out temp))
                {
                    vahvari.Volume = temp;
                    if (temp > 100)
                    {
                        Console.WriteLine("Äänenvoimakkuus liian korkea, asetettu 100");
                    }
                    else if (temp < 0)
                    {
                        Console.WriteLine("Äänenvoimakkuus liian matala, asetettu 0");
                    }
                    else
                    {
                        Console.WriteLine("Vahvistimen äänenvoimakkuus on " + vahvari.Volume);
                    }
                }
                else
                {
                    Console.WriteLine("Kiitos kun käytit vahvistinta");
                }
            }
        }
        static void TestaaEmployee()
        {
            Employee kirsi = new Employee("Kirsi", "työntekijä", 2800);
            Employee pomo = new Boss("Pomo", "isokenköinen", 5000, "iso auto");
            Console.WriteLine(kirsi.ToString());
            Console.WriteLine(pomo.ToString());
            kirsi.Profession = "parempi työntekijä";
            kirsi.Salary = 3000;
            Console.WriteLine(kirsi.ToString());
        }
        static void TestaaVehicle()
        {
            Vehicle auto = new Vehicle("Kärry", "Datsun", 1987, "Vihreä");
            Console.WriteLine(auto.ToString());
            Pyora bike = new Pyora("pyöätä", "Jopo", 1929, "Keltainen", true, "Monta");
            Console.WriteLine(bike.ToString());
            Vene vene = new Vene("paatti", "Laiva", 2019, "Sininen", "Sukellusvene", 5);
            Console.WriteLine(vene.ToString());
        }
    }
}
