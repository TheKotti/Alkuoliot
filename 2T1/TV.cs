using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class TV
    {
        public bool OnkoPaalla { get; set; }
        //äänenvoimakkuus voi olla 0-100
        int volume;
        int kanava;
        public int Kanava
        {
            get { return kanava; }
            set
            {
                kanava = value;
                if (kanava < 0)
                {
                    kanava = 0;
                }
            }
        }
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                if (volume > 100 ||volume < 0)
                {
                    volume = 0;
                }

            }
        }
    }
}
