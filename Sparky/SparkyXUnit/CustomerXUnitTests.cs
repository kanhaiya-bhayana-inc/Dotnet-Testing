using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sparky
{
    
    public class CustomerXUnitTests
    {
        private Customer customer;
        public CustomerXUnitTests() { customer = new Customer(); }
        [Fact]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            // Arrange
            // Customer customer = new Customer();
            string param1 = "Ben";
            string param2 = "Spark";
            string expected = "Hey, Ben Spark";

            // Act
            string actual = customer.GreetAndCombineName(param1, param2);

            // Asseert
            Assert.Multiple(() =>
            {
                Assert.Equal(expected, actual);
                Assert.Contains("ben spark".ToLower(), actual.ToLower());
                //Assert.StartsWith(param1, actual);
                Assert.EndsWith(param2.ToLower(), actual.ToLower());
                // we can also use the regex....
                Assert.Matches("Hey, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]",actual);
            });
        }

        [Fact]
        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
        {
            int startRange = 10;
            int endRange = 25;
            int actual = customer.Discount;

            Assert.InRange(actual, startRange, endRange);
        }

        [Fact]
        public void GreetMessage_GreetWithoutLastName_ReturnsNotNull()
        {
            customer.GreetAndCombineName("ben", "");

            //Assert.IsNotNull(customer.GreetMessage);
            Assert.NotNull(customer.GreetMessage);
        }

        [Fact]
        public void GreetChecker_EmptyFirstName_ThrowsException()
        {
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GreetAndCombineName("", "Spark"));
            Assert.Equal("Empty First Name",exceptionDetails.Message);
        }

        [Fact]
        public void CustomerType_CreateCustomerWithLessThan100Order_ReturnBasicCustomer()
        {
            customer.OrderTotal = 10;
            var result = customer.GetCustomerDetails();
            Assert.IsType<BasicCustomer>(result);
        }

        [Fact]
        public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnBasicCustomer()
        {
            customer.OrderTotal = 100;
            var result = customer.GetCustomerDetails();
            Assert.IsType<PlatinumCustomer>(result);
        }
    }
}
