namespace SimpleBankApp.Models
{
    public abstract class AccountFactory
    {
        public abstract Account CreateAccount();
    }

    public class SavingsAccountFactory : AccountFactory
    {
        public override Account CreateAccount()
        {
            return new SavingsAccount { Balance = 1000 };
        }
    }

    public class CheckingAccountFactory : AccountFactory
    {
        public override Account CreateAccount()
        {
            return new CheckingAccount { Balance = 1000 };
        }
    }
}
