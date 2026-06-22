using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    internal class Account
    {
        private int id;
        protected decimal balance;
        private string owner;
        private static int nextid = 1;
        public const decimal FEE = 5.0M;
        public readonly int FreeChecks;

        public Account()
        {
            id = nextid++;
            FreeChecks = 70;
        }
        public Account(decimal balance) : this()
        {
            this.balance = balance;
        }
        public Account(decimal balance, string owner) : this(balance)
        {
            this.owner = owner;
        }

        public static int GetNextID()
        {
            return nextid;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }
    }
}
