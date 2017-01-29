using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }
    }

    public class Joukkue
    {
        public string Nimi { get; set; }
        public string Kaupunki { get; set; }
        private List<Pelaaja> pelaajat;
        public List<Pelaaja> PelaajaLista
        {
            get { return pelaajat; }
        }

        public Joukkue()
        {

        }

        private void HaePelaajat(string joukkue)
        {

        }
    }
}
