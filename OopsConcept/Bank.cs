using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Bank
    {
        private double amt;
        private double bal;

        public Bank()
        {
            bal = 100000.0;
        }
        public void Deposit(double amt)
        {
            bal += amt;
        }
        public void Withdraw(double amt)
        {
            if (amt < bal)
                bal -= amt;
        }
        public string Print()
        {
            return $"Balance : {bal}";
        }
    }
}
