using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
     public abstract class Nisakas
    {
        public int Ika { get; set; }

        public abstract string Liiku();
    }

    public class Ihminen : Nisakas
    {
        //Properties
        public string Nimi { get; set; }
        public int Pituus { get; set; }
        public int Paino { get; set; }

        //Constructors
        public Ihminen()
        {

        }

        public Ihminen(string nimi, int ika, int pituus, int paino)
        {
            Nimi = nimi;
            Ika = ika;
            Pituus = pituus;
            Paino = paino;
        }

        //Methods
        public override string Liiku()
        {
            return "Liikun";
        }

        public void Kasva(int vuosi)
        {
            for (int i = 0; i < vuosi; i++)
            {
                Ika++;
            }
        }

        public override string ToString()
        {
            return Nimi + ", " + Ika + ", " + Pituus + ", " + Paino;
        }
    }

    public class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva(string nimi, int ika, int pituus, int paino, string vaippa)
                : base(nimi, ika, pituus, paino)
        {
            Vaippa = vaippa;
        }

        public override string Liiku()
        {
            return "Konttaa";
        }

        public override string ToString()
        {
            return base.ToString() + ", " + Vaippa;
        }
    }

    public class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public Aikuinen(string nimi, int ika, int pituus, int paino, string auto)
                : base(nimi, ika, pituus, paino)
        {
            Auto = auto;
        }

        public override string Liiku()
        {
            return "Kävelee";
        }

        public override string ToString()
        {
            return base.ToString() + ", " + Auto;
        }
    }
}
