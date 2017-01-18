using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Opiskelija
    {
        public string Nimi { get; set; }

        int opintopiste;
        public int OpintoPiste {
            get { return opintopiste; }
            set {
                opintopiste = value;
                if (opintopiste < 0)
                {
                    opintopiste = 0;
                }
            }
        }

        float promille;
        public float Promille
        {
            get { return promille; }
            set
            {
                promille = value;
                if (promille < 0.5)
                {
                    promille = 0.5F;
                } else if (promille > 10)
                {
                    promille = 10;
                }
            }
        }

        public void PrintData()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Opintopisteitä: " + OpintoPiste);
            Console.WriteLine("Alkoholia veressä: " + Promille);
            Console.WriteLine();
        }

        public Opiskelija(string nimi, int op, float promille)
        {
            Nimi = nimi;
            OpintoPiste = op;
            Promille = promille;
        }
    }
}
