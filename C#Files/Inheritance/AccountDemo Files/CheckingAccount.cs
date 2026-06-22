using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    internal class CheckingAccount : Account
    {
        private const decimal fee = 5.0M;

        public CheckingAccount(decimal balance, string owner) 
            : base(balance, owner)
        { 
        }
        public bool OrderCheckBook()
        {
            return true;
        }

        new public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }

            balance += (balance > 500) ? fee : 0;
        }

    }
}
