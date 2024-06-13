namespace SimpleBankApp.Models
{
    public class CheckingAccountStrategy : IAccountStrategy
    {
        public decimal GetBalance(Bank bank)
        {
            return bank.Balance;
        }
    }
}
