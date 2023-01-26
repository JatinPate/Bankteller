// See https://aka.ms/new-console-template for more information
using BankApp;

Console.WriteLine("Hello, World!");

Account myAccount1 = new Account(1111,"checking1111", 0);
Account myAccount2 = new Account(2222, "saving2222", 0);
Account myAccount3 = new Account(0, "?", 0);

Dictionary<string, Account> myMonies = new Dictionary<string, Account>();
myMonies.Add(myAccount1.AccountType, myAccount1);
myMonies.Add(myAccount2.AccountType, myAccount2);

Bank myBank = new Bank(myMonies); //adding the dictiorary to the bank constructor


int num = 3333;
bool isRunning = true;

while (isRunning)
{
    Console.Clear();
    Console.WriteLine("Weclome to Jatin's Bank! Choose the options below! \n");
    Console.WriteLine("1. Open a new account");
    Console.WriteLine("2. Check account balance");
    Console.WriteLine("3. Withdrawl");
    Console.WriteLine("4. Deposit");
    Console.WriteLine("5. Close your account");
    Console.WriteLine("6. Display account information");
    Console.WriteLine("7. Exit Program");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("What type of account would you like to make? Savings? Checking? Something else?");
            myAccount3.AccountType = Console.ReadLine() + num.ToString();
            myAccount3.AccountNumber = num;
            num++;
            myBank.OpenNewAccount(myAccount3); //adding account to bank

            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();

        break;
        case "2":
            myAccount3.CheckAccountBalance();

            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("How much monies would you like to withdrawl?");
            double Withdrawl = Convert.ToDouble(Console.ReadLine());
            myAccount3.Withdrawal(Withdrawl); //inputing the value we're trying to withdraw

            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            break;  
        case "4":
            Console.WriteLine("How much monies would you like to Deposit?");
            double deposit = Convert.ToDouble(Console.ReadLine());
            myAccount3.Deposit(deposit);
            Console.WriteLine($" You deposited {deposit} in your bank account which now as {myAccount3.AccountBalance}");

            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            break;
        case "5":
            myBank.RemoveAccount(myAccount3);

            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            break; 
        case "6":
            Console.WriteLine($"Account Number: {myAccount3.AccountNumber}\n AccountType: {myAccount3.AccountType}\n Account Balance: ${myAccount3.AccountBalance} "); //accountNumber, string accountType, double accountBalance

            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            break;
        case "7":


            isRunning = false;
            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Invalid Input! Try Again!");

            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
            break;
    }
}