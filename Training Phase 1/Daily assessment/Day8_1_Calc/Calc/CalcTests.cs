//ensures calculator is working correctly by testing it with different inputs.


using CalculatorLib;
using NUnit.Framework;
using System;

namespace CalcTests
{
    [TestFixture]
    public class CalcUnitTests
    {
        private Calc calc;

        [SetUp]
        public void Init() => calc = new Calc();

        [Test]
        public void Add_ReturnsSum()
        {
            Assert.Equals(5, calc.Add(2, 3));
            Assert.Equals(0, calc.Add(-1, 1));
            Assert.Equals(4.5, calc.Add(2.5, 2));
        }

        [Test]
        public void Subtract_ReturnsDifference()
        {
            Assert.Equals(1, calc.Subtract(3, 2));
            Assert.Equals(-4, calc.Subtract(1, 5));
        }

        [Test]
        public void Multiply_ReturnsProduct()
        {
            Assert.Equals(6, calc.Multiply(2, 3));
            Assert.Equals(0, calc.Multiply(0, 5));
            Assert.Equals(-4, calc.Multiply(-2, 2));
        }

        [Test]
        public void Divide_ReturnsQuotient()
        {
            Assert.Equals(2, calc.Divide(6, 3));
            Assert.Equals(-2.5, calc.Divide(5, -2));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(4, 0));
        }
    }
}
