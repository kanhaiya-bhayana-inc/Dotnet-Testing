using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class BankAccount
    {
        private readonly ILogBook _logBook;
        public int balance;

        public BankAccount(ILogBook logBook)
        {
            _logBook = logBook;
            balance = 0;
        }

        public bool Deposit(int amount)
        {
            balance += amount;
            _logBook.Message("Amount Deposited!");
            return true;
        }
        public bool Withdraw(int amount)
        {
            if (amount <= balance)
            {
                _logBook.LogToDb("Withdrawl Amount: "+ amount.ToString());  
                balance -= amount;
                return _logBook.LogBalanceAfterWithdrawl(balance);
            }
            return _logBook.LogBalanceAfterWithdrawl(balance - amount);
        }
        public int GetBalance()
        {
            return balance;
        }
    }
}
