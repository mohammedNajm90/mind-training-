using System;

namespace Bank
{
    public class Account
    {
        public string AccountNumber { get; private set; }
        public string HolderName { get; private set; }
        public string Password { get; private set; }
        public double Balance { get; private set; }

        public Account(string accountNumber, string holderName, string password)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Password = password;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposit successful! New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
            }
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
                return false;
            }
            if (amount > Balance)
            {
                Console.WriteLine($"Error: Insufficient funds. Current balance is {Balance:C}");
                return false;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawal successful! New balance: {Balance:C}");
            return true;
        }

        public void GetDetails()
        {
            Console.WriteLine($"\n--- Account Details ---");
            Console.WriteLine($"Account Number/Login ID: {AccountNumber}");
            Console.WriteLine($"Account Holder: {HolderName}");
            Console.WriteLine($"Balance: {Balance:C}");
            Console.WriteLine("-----------------------");
        }
    }
}
