namespace Chain_of_Responsibility.Account
{
    class Paypal : Account
    {
        public Paypal(decimal balance)
        {
            this.mBalance = balance;
        }
    }
}
