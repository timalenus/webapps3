using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public class Transaction
    {
        private decimal _amount;
        #region Properties
        public decimal Amount {
            get { return _amount; }
            private set {
                if (value <0) throw new ArgumentException("Amount cannot be negative");
                _amount = value; }
        }
        public TransactionType TransactionType { get; private set; }
        public DateTime DateOfTrans { get; private set; }
        #endregion

        #region Constructor
        public Transaction(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
            DateOfTrans = DateTime.Today;
        } 
        #endregion

        public bool IsDeposit
        {
            get { return TransactionType == TransactionType.Deposit; }

        }

        public bool IsWithdraw
        {
            get { return TransactionType == TransactionType.Withdraw; }

        }
    }
}

