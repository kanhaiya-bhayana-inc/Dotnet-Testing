﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class Customer
    {
        public string GreetAndCombineName(string firstName, string lastName)
        {
            return $"Hey, {firstName} {lastName}";
        }
    }
}
