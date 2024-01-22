using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sparky
{
    public class FiboXUnitTests
    {
        private Fibo fibo;
       
        public FiboXUnitTests()
        {
            fibo = new Fibo();
        }

        [Fact]
        public void FiboSeriesChecker_InputIntRange1_ReturnListOfFiboSeries()
        {
            var expected = new List<int>() { 0 };
            fibo.Range = 1;
            List<int> actual = fibo.GetFiboSeries();

            Assert.Multiple(() =>
            {
                Assert.NotEmpty(actual);
                Assert.Equal(actual.OrderBy(u=>u),actual);
                Assert.Equal(expected, actual);
            });
        }
        [Fact]
        public void FiboSeriesChecker_InputIntRange6_ReturnListOfFiboSeries()
        {
            var expected = new List<int>() { 0, 1, 1, 2, 3, 5 };
            fibo.Range = 6;
            List<int> actual = fibo.GetFiboSeries();

            Assert.Multiple(() =>
            {
                Assert.Contains(3,actual);
                Assert.Equal(6,actual.Count);
                Assert.DoesNotContain(4, actual);
                Assert.Equal(expected, actual);
            });
        }



    }
}
