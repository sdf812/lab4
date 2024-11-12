using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccount: IAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете!");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Баланс: {Balance}");
        }
    }
}
