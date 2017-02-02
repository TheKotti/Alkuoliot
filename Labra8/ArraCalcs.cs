using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class ArrayCalcs
    {
        public static double Sum(double[] array)
        {
            return array.Sum();
        }
        public static double Average(double[] array)
        {
            return Math.Round(array.Average(), 2);
        }
        public static double Max(double[] array)
        {
            return array.Max();
        }
        public static double Min(double[] array)
        {
            return array.Min();
        }
    }
}
