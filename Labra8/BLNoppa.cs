using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Noppa
    {
        private Random rng = new Random();
        public Noppa()
        {

        }
        public int Throw()
        {
            return rng.Next(1, 7);

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Product()
        {

        }

        public override string ToString()
        {
            return Name + " " + Price + "e";
        }
    }
    public class Place
    {
        public string Nimi { get; set; }
        public string Paikka { get; set; }
        public Place()
        {

        }
        public override string ToString()
        {
            return Nimi + " " + Paikka;
        }
    }

    public class Fish
    {
        public string Laji { get; set; }
        public float Pituus { get; set; }
        public float Paino { get; set; }
        public Place SaantiPaikka { get; set; }
        public Fish()
        {

        }
        public override string ToString()
        {
            return Laji + " " + Pituus + "m " + Paino + "kg " + SaantiPaikka.Nimi;
        }
    }

    public class Fisher
    {
        public string Nimi { get; set; }
        public string PuhNro { get; set; }

        private List<Fish> kalat;
        public List<Fish> KalaLista
        {
            get { return kalat; }
        }

        public Fisher()
        {
            kalat = new List<Fish>();
        }

        public string LisaaKala(Fish kala)
        {
            kalat.Add(kala);
            return "Rami sai kalan: " + kala.ToString();
        }
        public override string ToString()
        {
            return Nimi + " " + PuhNro;
        }
    }

    
}
