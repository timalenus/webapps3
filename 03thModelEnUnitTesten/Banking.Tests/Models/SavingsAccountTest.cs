using Banking.Models;
using System;
using Xunit;


namespace Banking.Tests.Models
{

    public class SavingsAccountTest
    {
        private static string savingsAccountNumber = "123-4567891-03";
        private SavingsAccount _savingsAccount;

        public  SavingsAccountTest()
        {
            _savingsAccount = new SavingsAccount(savingsAccountNumber, 0.02M);
            _savingsAccount.Deposit(200);
        }

        [Fact]
        public void WithdrawOnSavingsaccountCosts()
        {
            _savingsAccount.Withdraw(100);
            Assert.True(_savingsAccount.Balance < 100);
        }
        
        [Fact]
        public void WithdrawCausesTwoTransactions()
        {
            _savingsAccount.Withdraw(100);
            Assert.Equal(3, _savingsAccount.NumberOfTransactions);
        }

        [Fact]
        public void AddInterestChangesBalance()
        {
            _savingsAccount.AddInterest();
           Assert.Equal(204, _savingsAccount.Balance);
        }
        [Fact]
        public void Withdraw_IfBalanceGetsNegative_Fails()
        {
            Assert.Throws<InvalidOperationException>(() => _savingsAccount.Withdraw(200));
        }
    }
}