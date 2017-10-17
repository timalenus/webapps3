using Banking.Models;
using System;
using System.Collections.Generic;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount account = new BankAccount("123-4567890-12");
            Console.WriteLine($"Accountnumber - Balance: {account.ToString()}");
            //Console.WriteLine($"Balance: {account.Balance}");
            account.Deposit(200M);
            Console.WriteLine($"Balance after deposit of 200€: {account.Balance}");
            account.Withdraw(100M);
            Console.WriteLine($"Balance after withdraw of 100€: {account.Balance}");
            IEnumerable<Transaction> transactions = account.GetTransactions(null, null);
            foreach (Transaction t in transactions)
            {
                Console.WriteLine($"Transactions: {t.DateOfTrans.ToShortDateString()} - {t.Amount}");
            }
            SavingsAccount saving = new SavingsAccount("123-456789-03", 0.01M);
            saving.Deposit(200M);
            saving.Withdraw(100M);
            saving.AddInterest();
            Console.WriteLine($"Balance savingsaccount: {saving.ToString()}");
            Console.ReadKey();
        }
    }
}
