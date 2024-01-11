using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            // Arrange
            Customer customer = new Customer();
            string param1 = "Ben";
            string param2 = "Spark";
            string expected = "Hey, Ben Spark";

            // Act
            string actual = customer.GreetAndCombineName(param1, param2);

            // Asseert
            Assert.That(expected, Is.EqualTo(actual));
            Assert.That(expected, Does.Contain("ben Spark").IgnoreCase);
            //Assert.That(expected, Does.StartWith(param1).IgnoreCase);
            Assert.That(expected, Does.EndWith(param2).IgnoreCase);
            // we can also use the regex....
            Assert.That(expected, Does.Match("Hey, [A-Z]{1}"));

        }
    }
}
