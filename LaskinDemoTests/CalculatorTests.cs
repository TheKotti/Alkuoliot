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
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            ///AAA-periaate:
            ///Arrange, tietojen alustus
            ///Act, kutsutaan metodia
            ///Assert, varmistetaan että tulos ok

            //Arrange
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 9;

            //Act
            int actual = calc.Add(a, b);

            //Assert
            Assert.AreEqual(expected, actual);

            //toinen testi
            a = 0;
            b = 1;
            expected = 1;
            actual = calc.Add(a, b);
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //Arrange
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 20;

            //Act
            int actual = calc.Multiply(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DivideTest()
        {
            //Arrange
            Calculator calc = new Calculator();
            int a = 20;
            int b = 5;
            int expected = 4;

            //Act
            int actual = calc.Divide(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SubstractTest()
        {
            //Arrange
            Calculator calc = new Calculator();
            int a = 10;
            int b = 5;
            int expected = 5;

            //Act
            int actual = calc.Substract(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}