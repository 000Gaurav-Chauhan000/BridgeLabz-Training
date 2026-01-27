using NUnit.Framework;
using MyApp;
using System;

namespace MyApp.Tests
{
    [TestFixture]
    public class TestCases
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount();
        }

        [Test]
        public void Deposit_AddsToBalance()
        {
            account.Deposit(100);
            Assert.AreEqual(100, account.GetBalance());

            account.Deposit(50);
            Assert.AreEqual(150, account.GetBalance());
        }

        [Test]
        public void Withdraw_SubtractsFromBalance()
        {
            account.Deposit(200);
            account.Withdraw(50);
            Assert.AreEqual(150, account.GetBalance());
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            account.Deposit(100);
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(150));
        }

        [Test]
        public void Deposit_NegativeAmount_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => account.Deposit(-50));
        }

        [Test]
        public void Withdraw_NegativeAmount_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => account.Withdraw(-50));
        }
    }
}
