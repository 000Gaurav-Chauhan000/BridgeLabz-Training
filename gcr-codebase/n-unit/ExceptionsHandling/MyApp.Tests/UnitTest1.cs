using NUnit.Framework;
using MyApp;
using System;

namespace MyApp.Tests
{
    [TestFixture]
    public class TestCases
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Divide_ValidNumbers_ReturnsQuotient()
        {
            int result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() => calculator.Divide(10, 0));
        }
    }
}