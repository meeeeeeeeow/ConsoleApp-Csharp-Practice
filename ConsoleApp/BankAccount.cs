using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class BankAccount
    {
        private double money;
        private string owner;

        public BankAccount(double money, string owner)
        {
            this.money = money;
            this.owner = owner;
        }

        public double Money
        {
            get { return money; }
        }

        public string Owner
        {
            get { return owner; }
        }

        public static BankAccount operator +(BankAccount a, BankAccount b)
        {
            double newMoney = a.Money + b.Money;
            string newOwner = a.Owner + "_" + b.Owner;

            BankAccount newAccount = new BankAccount(newMoney, newOwner);
            return newAccount;
        }
    }
}
