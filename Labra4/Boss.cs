using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Boss : Employee
    {
        public string Car { get; set; }

        public Boss(string name, string profession, int salary, string car)
                : base(name, profession, salary)
        {
            Car = car;
        }
        public override string ToString()
        {
            return base.ToString() + ", Car: " + Car;
        }
    }
}
