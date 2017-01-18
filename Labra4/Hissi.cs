using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Hissi
    {
        int floor;
        public int CurrentFloor { 
            get { return floor; }
            set {
                floor = value;
                if (floor < 0 || floor > 5)
                {
                    floor = 1;
                }
            }
        }
    }
}
