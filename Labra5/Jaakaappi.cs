using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Jaakaappi
    {
        int tilaindex = 0;

        //Properties
        public string Nimi { get; set; }
        public int Tila { get; }
        public Ruoka[] Ruuat;

        //Constructors
        public Jaakaappi(string nimi, int tila)
        {
            Nimi = nimi;
            Ruuat = new Ruoka[tila];
        }

        //Methods
        public string LisaaRuoka(Ruoka ruoka)
        {
            if (tilaindex < Tila)
            {
                Ruuat[tilaindex] = ruoka;
                tilaindex++;
                return "Ruokaa lisätty jääkaappiin";
            }
            else
            {
                return "Jääkaappi on täynnä, ruokaa ei lisätty";
            }
        }
    }

    public class Ruoka
    {
        private DateTime temp;

        public string Nimi { get; set; }
        public string KayttoPaiva { get; set; }

        public Ruoka(string nimi, string paivays)
        {
            Nimi = nimi;
            temp = Convert.ToDateTime(paivays);
            KayttoPaiva = temp.Day + "/" + temp.Month + "/" + temp.Year;
        }
    }
}
