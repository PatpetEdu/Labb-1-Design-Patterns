using Labb_1___Implemementera.Models;
using Microsoft.AspNetCore.Mvc;
using SimpleBankApp.Models;

namespace SimpleBankApp.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            // Singleton pattern
            Bank bank = Bank.Instance;

            // Strategy pattern
            bank.SetStrategy(new SavingsAccountStrategy());
            decimal savingsBalance = bank.GetBalance();

            bank.SetStrategy(new CheckingAccountStrategy());
            decimal checkingBalance = bank.GetBalance();

            // Factory Method pattern: Creating accounts using factory
            AccountFactory savingsFactory = new SavingsAccountFactory();
            AccountFactory checkingFactory = new CheckingAccountFactory();

            Account savingsAccount = savingsFactory.CreateAccount();
            Account checkingAccount = checkingFactory.CreateAccount();

            // balances and account to view
            ViewBag.SavingsBalance = savingsBalance;
            ViewBag.CheckingBalance = checkingBalance;
            ViewBag.SavingsAccountType = savingsAccount.AccountType;
            ViewBag.CheckingAccountType = checkingAccount.AccountType;

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //To create new type of accounts
        [HttpPost]
        public IActionResult Create(string accountType)
        {
            Account account;
            if (accountType == "Savings")
            {
                AccountFactory factory = new SavingsAccountFactory();
                account = factory.CreateAccount();
            }
            else if (accountType == "Checking")
            {
                AccountFactory factory = new CheckingAccountFactory();
                account = factory.CreateAccount();
            }
            else
            {
                return BadRequest("Invalid account type");
            }


            ViewBag.AccountType = account.AccountType;
            ViewBag.Balance = account.Balance;

            return View("AccountCreated");
        }
    }
}
