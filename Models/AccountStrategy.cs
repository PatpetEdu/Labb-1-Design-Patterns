namespace SimpleBankApp.Models
{
    // Strategy pattern: Different account types
    public interface IAccountStrategy
    {
        decimal GetBalance(Bank bank);
    }
}
