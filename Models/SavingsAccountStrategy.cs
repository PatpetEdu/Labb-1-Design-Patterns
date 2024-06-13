namespace SimpleBankApp.Models
{
    public class SavingsAccountStrategy : IAccountStrategy
    {
        public decimal GetBalance(Bank bank)
        {
            return bank.Balance * 1.05m; // Example savings
        }
    }
}
