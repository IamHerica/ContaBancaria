namespace Banco.Entities
{//savings account é conta poupança
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        //copiei os paramentros da Account.cs, e acrescentei o paramentro interestRate
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            :base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance ()
        {
            Balance = +Balance * InterestRate;
        }

        public override void Withdraw(double amount) //saque, passando quantia
        {
            //aproveitar a implementação da Base
            base.Withdraw(amount);
            Balance -= 2.0; //isso pq vai descontar +2,00 de taxa, alem da taxa de saque da account
        }

    }
}
