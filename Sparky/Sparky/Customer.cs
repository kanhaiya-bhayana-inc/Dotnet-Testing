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
        public string GreetAndCombineName(string firstName, string lastName)
        {
            Discount = 25;
            return $"Hey, {firstName} {lastName}";
        }
    }
}
