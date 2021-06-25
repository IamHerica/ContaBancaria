using System;
using Banco.Entities;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            BusinessAccount ac1 = new BusinessAccount(5093, "Bob", 100.0, 500.0);

            Console.WriteLine(ac1.Balance);
        }
    }
}
