using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Entities
{
    class Account
    {
        public int Number { get; private set; }//num conta
        public string Holder { get; private set; }//titular da conta
        public double Balance { get; protected set; }//saldo da conta

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount) //saque, passando quantia
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
