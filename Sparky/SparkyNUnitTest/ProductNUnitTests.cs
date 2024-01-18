using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class ProductNUnitTests
    {
        //[SetUp] public void SetUp() { }

        [Test] 
        public void GetProductPrice_PlatinumCustomer_REturnPriceWith20Discount()
        {

            Product product = new Product() { Price = 100 };
            var expected = 80;

            var actual = product.GetPrice(new Customer() { IsPlatinum = true });
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
