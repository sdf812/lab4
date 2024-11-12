using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IAccountManager
    {
        void OpenAccount(string accountNumber, double initialBalance);
        void CloseAccount(string accountNumber);
        void Deposit(string accountNumber, double amount);
        void Withdraw(string accountNumber, double amount);
    }
}
