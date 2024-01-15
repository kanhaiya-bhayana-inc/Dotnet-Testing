using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class FiboNUnitTests
    {
        private Fibo fibo;
        [SetUp]
        public void SetUp()
        {
            fibo = new Fibo();
        }

        [Test]
        public void FiboSeriesChecker_InputIntRange1_ReturnListOfFiboSeries()
        {
            var expected = new List<int>() { 0 };
            fibo.Range = 1;
            List<int> actual = fibo.GetFiboSeries();

            Assert.Multiple(() =>
            {
                Assert.That(actual, Is.Not.Empty);
                Assert.That(actual, Is.Ordered);
                Assert.That(actual, Is.EquivalentTo(expected));
            });
        }
        [Test]
        public void FiboSeriesChecker_InputIntRange6_ReturnListOfFiboSeries()
        {
            var expected = new List<int>() { 0, 1, 1, 2, 3, 5 };
            fibo.Range = 6;
            List<int> actual = fibo.GetFiboSeries();

            Assert.Multiple(() =>
            {
                Assert.That(actual, Does.Contain(3));
                Assert.That(actual.Count, Is.EqualTo(6));
                Assert.That(actual, Has.No.Member(4));
                Assert.That(actual, Is.EquivalentTo(expected));
            });
        }



    }
}
