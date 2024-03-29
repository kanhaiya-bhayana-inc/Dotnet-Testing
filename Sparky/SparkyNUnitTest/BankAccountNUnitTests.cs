﻿using Moq;
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
        private BankAccount account;
        [SetUp] public void SetUp() {
            
        }

        //[Test]
        //public void BankDepositLogFakker_Add100_ReturnTrue()
        //{
        //    BankAccount bankAccount = new(new LogFakker());
        //    var expected = 100;
        //    Assert.That(bankAccount.Deposit(100), Is.True);

        //    var actual = bankAccount.GetBalance();
        //    Assert.That(actual, Is.EqualTo(expected));
        //}
        [Test]

        public void BankDeposit_Add100_ReturnTrue()
        {
            var logMock = new Mock<ILogBook>();

            BankAccount bankAccount = new(logMock.Object);
            var expected = 100;
            Assert.That(bankAccount.Deposit(100), Is.True);

            var actual = bankAccount.GetBalance();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BankWithdraw_Withdraw100With200Balance_ReturnsTrue()
        {
            var logMock = new Mock<ILogBook>(); 
            logMock.Setup( u => u.LogToDb(It.IsAny<string>())).Returns(true);
            logMock.Setup( u => u.LogBalanceAfterWithdrawl(It.IsAny<int>())).Returns(true);

            BankAccount bankAccount = new(logMock.Object);
            bankAccount.Deposit(200);
            var result = bankAccount.Withdraw(300);
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(200,300)]
        public void BankWithdraw_Withdraw300With200Balance_ReturnsFalse(int balance, int withdraw)
        {
            var logMock = new Mock<ILogBook>();
            logMock.Setup(u => u.LogBalanceAfterWithdrawl(It.Is<int>(x => x > 0))).Returns(true);
            logMock.Setup(u => u.LogBalanceAfterWithdrawl(It.Is<int>(x => x < 0))).Returns(false);

            BankAccount bankAccount = new(logMock.Object);
            bankAccount.Deposit(balance);
            var result = bankAccount.Withdraw(withdraw);
            Assert.That(result, Is.False);
        }

        [Test]
        public void BankLogDummy_LogMocString_ReturnTrue()
        {
            var logMock = new Mock<ILogBook>();
            string expected = "hello";

            logMock.Setup(u => u.MessageWithReturnStr(It.IsAny<string>())).Returns((string str)=> str.ToLower());

            Assert.That(logMock.Object.MessageWithReturnStr("HElLo"), Is.EqualTo(expected));
        }

        [Test]
        public void BankLogDummy_LogMockStringOutputStr_ReturnTrue()
        {
            var logMock = new Mock<ILogBook>();
            string expected = "hello";

            logMock.Setup(u => u.LogWithOutputResult(It.IsAny<string>(), out expected)).Returns(true);
            string actual = "";
            Assert.That(logMock.Object.LogWithOutputResult("Ben", out actual),Is.True);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BankLogDummy_LogRefChecker_ReturnTrue()
        {
            var logMock = new Mock<ILogBook>();
            Customer customer = new();
            Customer customerNotUsed = new();


            logMock.Setup(u => u.LogWithRefObj(ref customer)).Returns(true);
            Assert.That(logMock.Object.LogWithRefObj(ref customer), Is.True);
        }

        [Test]
        public void BankLogDummy_SetAndGetLogTypeAndSeveirtyMock_MockTest()
        {
            var logMock = new Mock<ILogBook>();
            logMock.SetupAllProperties();
            logMock.Setup(u => u.LogSeverity).Returns(10);
            logMock.Setup(u => u.LogType).Returns("Warning");

            //logMock.Object.LogSeverity = 100;           
            Assert.That(logMock.Object.LogSeverity, Is.EqualTo(10));
            Assert.That(logMock.Object.LogType, Is.EqualTo("Warning"));

            // callbacks
            string logTemp = "Hello, ";
            logMock.Setup(u => u.LogToDb(It.IsAny<string>()))
                .Returns(true).Callback((string str)=> logTemp += str);

            logMock.Object.LogToDb("Ben");
            Assert.That(logTemp, Is.EqualTo("Hello, Ben"));

            // callbacks
            int counter = 5;
            logMock.Setup(u => u.LogToDb(It.IsAny<string>()))
                .Returns(true).Callback(()=>counter++);
            logMock.Object.LogToDb("Ben");
            logMock.Object.LogToDb("Ben");
            Assert.That(counter, Is.EqualTo(7));
        }

        [Test]
        public void BankLogDummy_VerifyExample()
        {
            var logMock = new Mock<ILogBook>();
            BankAccount bankAccount = new(logMock.Object);
            bankAccount.Deposit(100);
            Assert.That(bankAccount.GetBalance, Is.EqualTo(100));

            // verification
            logMock.Verify(u => u.Message(It.IsAny<string>()),Times.Exactly(2));
            logMock.VerifySet(u => u.LogSeverity = 101, Times.Once);
        }
    }
}
