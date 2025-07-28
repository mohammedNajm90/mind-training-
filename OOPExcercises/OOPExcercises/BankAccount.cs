using System;


namespace OOPExcercises
{
    public class BankAccount
    {
        public int AccountNumber { get; protected set; }
        public double Balance { get; protected set; }

        public BankAccount(double balance)
        {
            Random random = new Random();
            AccountNumber = random.Next(1000);
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
