using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IAccount
    {
        string AccountNumber { get; set; }
        double Balance { get; set; }

        void Deposit(double amount);
        void Withdraw(double amount);
        void DisplayAccountInfo();
    }
}
