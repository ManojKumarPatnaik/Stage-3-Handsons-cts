using CalcLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
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
        [TestCase(2,3,5)]
        public void TestAdd(double x,double y,double z)
        {
            SimpleCalculator c = new SimpleCalculator();
            actual = c.Addition(x, y);
            Assert.AreEqual(z, actual);
        }

        [TearDown]
        public void Clear()
        {

        }
    }
}
