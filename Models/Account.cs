namespace SimpleBankApp.Models
{
    public abstract class Account
    {
        public decimal Balance { get; set; }
        public abstract string AccountType { get; }
    }

    public class SavingsAccount : Account
    {
        public override string AccountType => "Savings";
    }

    public class CheckingAccount : Account
    {
        public override string AccountType => "Checking";
    }
}
