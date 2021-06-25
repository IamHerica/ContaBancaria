using System;
using Banco.Entities;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex", 0.0);
            BusinessAccount acc2 = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING: converter uma subclasse para classe
            acc1 = acc2;
            Account acc3 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc4 = new SavingsAccount(1004, "Isa", 0.0, 0.01);

            //DOWNCASTING: de classe para subclasse (operacao insegura, usado somente se for necessario)

            BusinessAccount acc5 = (BusinessAccount)acc3;
            acc5.Loan(100.0);


            // :::ERRO::: BusinessAccount acc6 = (BusinessAccount)acc4;
            if (acc4 is BusinessAccount) //acc3 é uma instancia de BussinessAccount?
            {
                BusinessAccount acc6 = (BusinessAccount)acc4; 
                //ou podemo fazer assim:
                //BusinessAccount acc6 = acc4 as BusinessAccount;


                acc6.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc4 is SavingsAccount)
            {
                SavingsAccount acc6 = (SavingsAccount)acc4;
                acc6.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
