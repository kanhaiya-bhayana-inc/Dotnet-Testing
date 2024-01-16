using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class BankAccountNUnitTests
    {
        private BankAccount bankAccount;
        [SetUp] public void SetUp() {
            bankAccount = new(new LogBook());
        }

        [Test]
        public void BankDeposit_Add100_ReturnTrue()
        {
            var expected = 100;
            Assert.That(bankAccount.Deposit(100), Is.True);

            var actual = bankAccount.GetBalance();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
