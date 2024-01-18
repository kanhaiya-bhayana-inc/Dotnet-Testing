using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class LogBook : ILogBook
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
        

        bool ILogBook.LogToDb(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        bool ILogBook.LogBalanceAfterWithdrawl(int balanceAfterWithdrawl)
        {
            if (balanceAfterWithdrawl >= 0)
            {
                Console.WriteLine("Success");
                return true;
            }
            Console.WriteLine("Failure");
            return false;   
        }
    }
}
