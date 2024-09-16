using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibraryTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void TestAddition()
        {
            double result = _calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            double result = _calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            double result = _calculator.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            double result = _calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            _calculator.Divide(5, 0);
        }
    }
}