using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Radio
    {
        //Properties
        public bool OnkoPaalla { get; set; }

        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                if (volume > 9)
                {
                    volume = 9;
                }
                else if (volume < 0)
                {
                    volume = 0;
                }
            }
        }

        private float taajuus;
        public float Taajuus
        {
            get { return taajuus; }
            set
            {
                taajuus = value;
                if (taajuus > 26000.0F)
                {
                    taajuus = 26000.0F;
                }
                else if (taajuus < 2000.0F)
                {
                    taajuus = 2000.0F;
                }
            }
        }

        //Constructors
        public Radio()
        {

        }

        public Radio (bool paalla, int volume, float taajuus)
        {
            OnkoPaalla = paalla;
            Volume = volume;
            Taajuus = taajuus;
        }

        //Methods
        public override string ToString()
        {
            return "Radio on päällä: " + OnkoPaalla + ", äänenvoimakkuus: " + Volume + ", taajuus: " + Taajuus.ToString(".0");
        }
    }
}
