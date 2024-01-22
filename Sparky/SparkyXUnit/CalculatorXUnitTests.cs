using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sparky
{
    public class CalculatorXUnitTests
    {
        private Calculator calculator;
        
        public CalculatorXUnitTests()
        {
            calculator = new Calculator();
        }
        [Fact]
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
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            // Arrange
            // Calculator calculator = new();
            int param1 = 10;
            bool excpected = false;

            // Act 
            bool actual = calculator.IsOddNumber(param1);

            // Assert
            Assert.Equal(actual, excpected);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {
            // Arrange
            // Calculator calculator = new();
            int param1 = a;
            bool excpected = true;

            // Act 
            bool actual = calculator.IsOddNumber(param1);

            // Assert
            Assert.Equal(actual, excpected);
        }

        [Fact]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            // Arrange
            int min = 3;
            int max = 10;
            List<int> expected = new List<int> { 3, 5, 7, 9 };

            // Act
            List<int> actual = calculator.OddRange(min, max);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.Equal(expected, actual);
                Assert.Contains(7, actual);
                Assert.Equal(4, actual.Count);
                Assert.NotEmpty(actual);
                Assert.DoesNotContain(6,actual);
                Assert.Equal(actual.OrderBy(u=>u), actual);
                //Assert.That(actual, Is.Ordered.Descending);
                //Assert.That(actual, Is.Unique);
            });
        }
    }
}
