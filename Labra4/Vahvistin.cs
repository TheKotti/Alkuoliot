using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vahvistin
    {
        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                if (volume > 100)
                {
                    volume = 100;
                }
                else if (volume < 0)
                {
                    volume = 0;
                }
            }
        }
    }
}
