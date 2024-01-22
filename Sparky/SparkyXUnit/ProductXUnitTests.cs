using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sparky
{
 
    public class ProductXUnitTests
    {
        //[SetUp] public void SetUp() { }

        [Fact]
        public void GetProductPrice_PlatinumCustomer_REturnPriceWith20Discount()
        {

            Product product = new Product() { Price = 100 };
            var expected = 80;

            var actual = product.GetPrice(new Customer() { IsPlatinum = true });
            Assert.Equal(expected, actual);
        }
    }
}
