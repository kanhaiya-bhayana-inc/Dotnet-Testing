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
    }
}
