using System;

namespace Bank
{
    public class BankUI
    {
        private Bank bank;

        public BankUI()
        {
            bank = new Bank();
        }

        public void Start()
        {
            while (true)
            {
                PrintHeader("Welcome to the Bank of Iraq");
                Console.WriteLine("1. Customer Login");
                Console.WriteLine("2. Employee Login");
                Console.WriteLine("0. Exit");
                Console.Write("Choose your role: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": HandleCustomerSession(); break;
                    case "2": HandleEmployeeSession(); break;
                    case "0":
                        Console.WriteLine("\nThank you for using our bank. Goodbye!");
                        return;
                    default: PrintError("Invalid option, please try again."); break;
                }
            }
        }

        private void HandleEmployeeSession()
        {
            PrintHeader("Employee Login");
            Console.Write("Enter username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Employee employee = bank.FindEmployee(userName);
            if (employee == null || employee.Password != password)
            {
                PrintError("Invalid username or password.");
                return;
            }

            Console.WriteLine($"\nWelcome, {employee.Username}!");
            while (true)
            {
                PrintHeader("Employee Menu");
                Console.WriteLine("1. Create New Account");
                Console.WriteLine("2. Delete Account");
                Console.WriteLine("3. Add New Employee");
                Console.WriteLine("4. Show All Accounts");
                Console.WriteLine("5. Show All Transactions");
                Console.WriteLine("0. Logout");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "0") { Console.WriteLine("Logging out..."); break; }

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter new Account Number: ");
                        string accountNumber = Console.ReadLine();
                        Console.Write("Enter Holder Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        string accountPassword = Console.ReadLine();
                        employee.CreateNewAccount(bank, accountNumber, name, accountPassword);
                        break;
                    case "2":
                        Console.Write("Enter Account Number to delete: ");
                        string accountToDelete = Console.ReadLine();
                        bank.DeleteAccount(accountToDelete);
                        break;

                    case "3":
                        Console.Write("Enter new employee's username: ");
                        string newUserName = Console.ReadLine();
                        Console.Write("Enter new employee's password: ");
                        string newPassword = Console.ReadLine();
                        employee.CreateNewEmployee(bank, newUserName, newPassword);
                        break;
                    case "4": ShowAllAccounts(); break;
                    case "5": ShowAllTransactions(); break;
                    default: PrintError("Invalid option."); break;
                }
            }
        }

        private void HandleCustomerSession()
        {
            PrintHeader("Customer Login");
            Console.Write("Enter Account Number: ");
            string accountNum = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Account account = bank.FindAccount(accountNum);
            if (account == null || account.Password != password)
            {
                PrintError("Invalid account number or password.");
                return;
            }

            Console.WriteLine($"\nWelcome, {account.HolderName}!");
            while (true)
            {
                PrintHeader("Customer Menu");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Transfer");
                Console.WriteLine("4. Show My Account Details");
                Console.WriteLine("5. Show My Transactions");
                Console.WriteLine("0. Logout");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "0") { Console.WriteLine("Logging out..."); break; }

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Amount to Deposit: ");
                        double.TryParse(Console.ReadLine(), out double depositAmount);
                        account.Deposit(depositAmount);
                        break;
                    case "2":
                        Console.Write("Enter Amount to Withdraw: ");
                        double.TryParse(Console.ReadLine(), out double withdrawAmount);
                        account.Withdraw(withdrawAmount);
                        break;
                    case "3":
                        Console.Write("Enter Receiver Account Number: ");
                        string receiverAccountNumber = Console.ReadLine();
                        Console.Write("Enter Amount to Transfer: ");
                        double.TryParse(Console.ReadLine(), out double transAmount);

                        Account receiver = bank.FindAccount(receiverAccountNumber);
                        if (receiver == null)
                        {
                            PrintError("Receiver account not found.");
                            break;
                        }

                        Transaction transaction = new Transaction(account, receiver, transAmount);
                        transaction.Transfer(); 

                        if (transaction.IsSuccessful)
                        {
                            bank.Transactions.Add(transaction);
                        }
                        break;
                    case "4": account.GetDetails(); break;
                    case "5": ShowTransactionsOfAccount(account.AccountNumber); break;
                    default: PrintError("Invalid option."); break;
                }
            }
        }

        private void ShowAllAccounts()
        {
            PrintHeader("All Customer Accounts");
            if (bank.Accounts.Count == 0)
            {
                Console.WriteLine("No accounts found in the system.");
                return;
            }
            foreach (var acc in bank.Accounts)
            {
                acc.GetDetails();
            }
        }

        private void ShowAllTransactions()
        {
            PrintHeader("All System Transactions");
            if (bank.Transactions.Count == 0)
            {
                Console.WriteLine("No transactions found in the system.");
                return;
            }
            foreach (var tx in bank.Transactions)
            {
                tx.PrintReceipt();
            }
        }

        private void ShowTransactionsOfAccount(string accountNumber)
        {
            PrintHeader($"Transactions for Account {accountNumber}");
            bool found = false;
            foreach (var tx in bank.Transactions)
            {
                if (tx.Sender.AccountNumber == accountNumber || tx.Receiver.AccountNumber == accountNumber)
                {
                    tx.PrintReceipt();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No transactions found for this account.");
            }
        }

        private void PrintHeader(string title)
        {
            Console.WriteLine($"\n===== {title} =====");
            Console.ResetColor();
        }

        private void PrintError(string message)
        {
            Console.WriteLine($"\nError: {message}");
            Console.ResetColor();
        }
    }
}
