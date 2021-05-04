
using CalcLibrary2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTester
{
    [TestFixture]
    public class CalculatorTests
    {
        double actual;
        [SetUp]
        public void Init()
        {
            actual = 0;
        }

        [Test]
        [TestCase(5, 2, 3)]
        [TestCase(4, 6, -2)]
        public void TestSub(double x, double y, double z)
        {
            SimpleCalculator c = new SimpleCalculator();
            actual = c.Subtraction(x, y);
            Assert.AreEqual(z, actual);
        }


        [Test]
        [TestCase(5, 2, 10)]
        [TestCase(4, 6, 24)]
        public void TestMul(double x, double y, double z)
        {
            SimpleCalculator c = new SimpleCalculator();
            actual = c.Multiplication(x, y);
            Assert.AreEqual(z, actual);
        }


        [Test]
        [TestCase(20, 2, 10)]
        [TestCase(4, 0, 0)]
        public void TestDiv(double x, double y, double z)
        {
            try
            {
                SimpleCalculator c = new SimpleCalculator();
                actual = c.Division(x, y);
                Assert.AreEqual(z, actual);
            }
            catch (ArgumentException)
            {
                Assert.Fail("Division by zero");
            }
        }

        [Test]
        [TestCase(20, 10, 30)]
        public void TestAddAndClear(double x, double y, double z)
        {
            SimpleCalculator c = new SimpleCalculator();
            c.Addition(x, y);
            Assert.AreEqual(z, c.GetResult);
            c.AllClear();
            Assert.AreEqual(0, c.GetResult);
        }
    }
}
