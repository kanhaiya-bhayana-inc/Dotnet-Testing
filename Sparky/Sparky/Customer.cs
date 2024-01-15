using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class Customer
    {
        public int Discount = 20;
        public string GreetMessage { get; set; }
        public string GreetAndCombineName(string firstName, string lastName)
        {
            Discount = 25;
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("Empty First Name");
            }
            GreetMessage = $"Hey, {firstName} {lastName}";
            return GreetMessage;
        }
    }
}
