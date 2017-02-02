using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        double[] array = { 1.0, 2.0 };
        [TestMethod()]
        public void SumTest()
        {
            double expected = 3.0;
            double actual = ArrayCalcs.Sum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double expected = 1.5;
            double actual = ArrayCalcs.Average(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double expected = 2.0;
            double actual = ArrayCalcs.Max(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            double expected = 1.0;
            double actual = ArrayCalcs.Min(array);
            Assert.AreEqual(expected, actual);
        }
    }
}