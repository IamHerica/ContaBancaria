namespace Banco.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; } //limite de emprestimo

        public BusinessAccount()
        {
            //opcao de criar o objeto sem passar os dados
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            :base(number, holder, balance)
        {
            //para nao ter repeticoes de codigo, usamos o base, passando os dados que são passado para o construtor da Account.cs
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) //emprestimo
        {
            if (amount <= LoanLimit)
                Balance += amount;
        }

    }
}
