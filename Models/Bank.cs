using System;

namespace SimpleBankApp.Models
{
    // Singleton pattern
    public class Bank
    {
        private static readonly Lazy<Bank> instance = new Lazy<Bank>(() => new Bank());

        public static Bank Instance => instance.Value;

        public decimal Balance { get; set; } = 1000; // anger Saldo

        private IAccountStrategy strategy;

        private Bank() { }

        public void SetStrategy(IAccountStrategy strategy)
        {
            this.strategy = strategy;
        }

        public decimal GetBalance()
        {
            return strategy.GetBalance(this);
        }
    }
}
