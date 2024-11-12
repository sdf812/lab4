using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AccountManager: IAccountManager
    {
        private Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();

        public void OpenAccount(string accountNumber, double initialBalance)
        {
            BankAccount newAccount = new BankAccount(accountNumber, initialBalance);
            accounts.Add(accountNumber, newAccount);
        }

        public void CloseAccount(string accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts.Remove(accountNumber);
            }
            else
            {
                Console.WriteLine("Счет не найден.");
            }
        }

        public void Deposit(string accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Счет не найден.");
            }
        }

        public void Withdraw(string accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber].Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Счет не найден.");
            }
        }
    }
}
