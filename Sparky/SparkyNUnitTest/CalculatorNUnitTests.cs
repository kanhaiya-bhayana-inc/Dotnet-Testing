using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // Arrange
            // Calculator calc = new();
            int param1 = 10;
            int param2 = 20;
            int expected = 30;

            // Act
            int actual = calculator.AddNumbers(param1, param2);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            // Arrange
            // Calculator calculator = new();
            int param1 = 10;
            bool excpected = false;

            // Act 
            bool actual = calculator.IsOddNumber(param1);

            // Assert
            Assert.That(excpected, Is.EqualTo(actual));
        }

        [Test]
        [TestCase(1)]
        [TestCase(3)]
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {
            // Arrange
            // Calculator calculator = new();
            int param1 = a;
            bool excpected = true;

            // Act 
            bool actual = calculator.IsOddNumber(param1);

            // Assert
            Assert.That(excpected, Is.EqualTo(actual));
        }
    }
}
