using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Bank
    {
        Dictionary<string, Account> bankAccounts = new Dictionary<string, Account>(); //dictionsry of accounts with savings/checking as keys and Account as value

        public Dictionary<string,Account> BankAccounts { get; set; }
        
        public Bank(Dictionary<string, Account> accounts)
        {
            BankAccounts = bankAccounts;
        }

        public Dictionary<string,Account> GetAllAccounts()
        {
            return BankAccounts;
        }

        public void OpenNewAccount(Account account)
        {
            BankAccounts.Add(account.AccountType, account);
        }

        public Account GetAccount(string accountType)
        {
            return BankAccounts[accountType];
        }
        public void RemoveAccount(Account account)
        {
            if (bankAccounts.ContainsKey(account.AccountType)) //checks if the account is even there 
            {
                BankAccounts.Remove(account.AccountType);
            }
            
        }

    }
}
