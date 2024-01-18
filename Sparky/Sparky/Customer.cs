using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class Customer
    {
        public int OrderTotal;
        public int Discount = 20;
        public string GreetMessage { get; set; }
        public bool IsPlatinum { get; set; }
        public Customer()
        {
            IsPlatinum = false;
        }
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

        public CustomerType GetCustomerDetails()
        {
            if (OrderTotal < 100)
            {
                return new BasicCustomer();
            }
            return new PlatinumCustomer();
        }
    }

    public class CustomerType { }
    public class BasicCustomer : CustomerType { }
    public class PlatinumCustomer : CustomerType { }

}
