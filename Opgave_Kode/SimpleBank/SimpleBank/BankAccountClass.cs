using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        public string Name { get; set; }
        private bool locked;
        private double balance;

        public double Balance
        {
            get { return balance; }
        }

        public BankAccount (string name, double balance, bool locked)
        {
            this.Name = name;
            this.locked = locked;
            this.balance = balance;
        }
        public BankAccount(string name, double balance) :
            this (name, balance, false)
        {
        }
        public BankAccount(double balance) :
            this("", balance, false)
        {
        }
        public void Deposit (double amount)
        {
            if (locked == false)
            {
                balance = amount + balance;
            }
        }

        public void Withdraw (double amount)
        {
            if (locked == false && amount <= Balance)
            {
                balance = balance - amount;
            }
        }
        public void ChangeLockState()
        {
            if (locked == true)
                locked = false;
            else 
                locked = true;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Balance: {Balance}";
        }
    }
}
