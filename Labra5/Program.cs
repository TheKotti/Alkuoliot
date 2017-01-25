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
            //AutoTest();
            //NisakasTest();
            KaappiTest();
        }
        static void AutoTest()
        {
            Rengas rengas1 = new IT.Rengas("Nokia", "Hakkapeliita", "XYZ123");
            Auto auto1 = new IT.Auto("Porsche", "911", 2014, "Vihreä");
            auto1.LisaaRengas(rengas1, 5);
            Console.WriteLine(rengas1.ToString());
            Console.WriteLine(auto1.ToString());
        }
        static void NisakasTest()
        {
            Ihminen heppu = new Ihminen("heppu", 25, 160, 57);
            Console.WriteLine(heppu.ToString());
            Console.WriteLine(heppu.Liiku());
            heppu.Kasva(8);
            Console.WriteLine(heppu.ToString());

            Vauva vauva = new Vauva("kräääh", 0, 123, 21, "Haisee");
            Console.WriteLine(vauva.ToString());
            Console.WriteLine(vauva.Liiku());
            vauva.Kasva(1);
            Console.WriteLine(vauva.ToString());

            Aikuinen aikuinen = new Aikuinen("joku häiskä", 56, 258, 94, "Rikki");
            Console.WriteLine(aikuinen.ToString());
            Console.WriteLine(aikuinen.Liiku());
            aikuinen.Kasva(58);
            Console.WriteLine(aikuinen.ToString());
        }
        static void KaappiTest()
        {
            Jaakaappi jk1 = new Jaakaappi("Samsung", 5);
            Ruoka olut = new IT.Ruoka("Karhu", "10/12/2015");
            Ruoka makkara = new IT.Ruoka("Grilli", "15/09/2020");
            Console.WriteLine(jk1.LisaaRuoka(olut));
            Console.WriteLine(jk1.LisaaRuoka(makkara));
            Console.WriteLine(jk1.LisaaRuoka(olut));
            Console.WriteLine(jk1.LisaaRuoka(makkara));
            Console.WriteLine(jk1.LisaaRuoka(olut));
            Console.WriteLine(jk1.LisaaRuoka(makkara));
            Console.WriteLine(jk1.LisaaRuoka(olut));
            for (int i = 0; i < jk1.Ruuat.Length; i++)
            {
                if (jk1.Ruuat[i] != null)
                {
                    Console.WriteLine(jk1.Ruuat[i].Nimi + ", " + jk1.Ruuat[i].KayttoPaiva);
                }
            }
        }
    }
}
