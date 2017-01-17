using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2T1
{
    class Vehicle
    {
        public string Name { get; set; }

        int speed;
        public int Speed {
            get { return speed; }
            set {
                speed = value;
                if (speed < 0)
                {
                    speed = 0;
                }
            }
        }

        int tyres;
        public int Tyres
        {
            get { return tyres; }
            set
            {
                tyres = value;
                if (tyres < 0)
                {
                    tyres = 0;
                }
            }
        }

        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        override public string ToString()
        {
            return Name + " " + Speed + " " + Tyres;
        }
    }
}
