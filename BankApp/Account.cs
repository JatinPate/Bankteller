using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        private int accountNumber;
        private string accountType;
        private double accountBalance;

        public Account(int accountNumber, string accountType, double accountBalance)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;
        }

        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; } //could be decimal


        public void Deposit(double money)
        {
            AccountBalance = AccountBalance + money;
        }

        public void Withdrawal(double money) 
        {
            AccountBalance = AccountBalance - money;
        }

        public void CheckAccountBalance()
        {
            Console.WriteLine("Account Balance is: " + AccountBalance);
        }







    }
}
