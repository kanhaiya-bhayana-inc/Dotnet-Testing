using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class LogFakker : ILogBook
    {
        public int LogSeverity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LogType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool LogBalanceAfterWithdrawl(int balanceAfterWithdrawl)
        {
            throw new NotImplementedException();
        }

        public bool LogToDb(string message)
        {
            throw new NotImplementedException();
        }

        public bool LogWithOutputResult(string str, out string outputStr)
        {
            throw new NotImplementedException();
        }

        public bool LogWithRefObj(ref Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Message(string message)
        {
        }

        public string MessageWithReturnStr(string message)
        {
            throw new NotImplementedException();
        }
    }
}
