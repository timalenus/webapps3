using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public class SavingsAccount : BankAccount
    {
        protected const decimal WithdrawCost = 0.25M;

        public decimal InterestRate { get; private set; }

        public SavingsAccount(string bankAccountNumber, decimal interestRate):base(bankAccountNumber)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount + WithdrawCost > Balance) throw new InvalidOperationException("Balance cannot be negative");
            base.Withdraw(amount);
            base.Withdraw(WithdrawCost);
        }

        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }
    }
}
