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
    }
}
