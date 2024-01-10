using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyMSTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // Arrange
            Calculator calc = new();
            int param1 = 10;
            int param2 = 20;
            int expected = 30;

            // Act
            int actual = calc.AddNumbers(param1,param2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
