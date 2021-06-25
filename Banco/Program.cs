using System;
using Banco.Entities;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Account c1 = new Account(1001, "Ana", 500.0);
            Account c2 = new SavingsAccount(1002, "João", 500.0, 0.01);

            c1.Withdraw(10.0);
            c2.Withdraw(10.0);

            Console.WriteLine("Conta padrão: " + c1.Balance);
            Console.WriteLine("Conta poupança: " + c2.Balance);
        }
    }
}
