using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class LogFakker : ILogBook
    {
        public bool LogBalanceAfterWithdrawl(int balanceAfterWithdrawl)
        {
            throw new NotImplementedException();
        }

        public bool LogToDb(string message)
        {
            throw new NotImplementedException();
        }

        public void Message(string message)
        {
        }
    }
}
