using System;

namespace Bank
{
    public class Transaction
    {
        public string TransactionId { get; private set; }
        public Account Sender { get; private set; }
        public Account Receiver { get; private set; }
        public double Amount { get; private set; }
        public DateTime Date { get; private set; }
        public bool IsSuccessful { get; private set; }

        public Transaction(Account sender, Account receiver, double amount)
        {
            TransactionId = Guid.NewGuid().ToString();
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
            Date = DateTime.Now;
            IsSuccessful = false;
        }

        public void Transfer()
        {
            if (Sender.AccountNumber == Receiver.AccountNumber)
            {
                Console.WriteLine("Error: Sender and receiver accounts cannot be the same.");
                return;
            }

            if (Amount <= 0)
            {
                Console.WriteLine("Error: Transfer amount must be positive.");
                return;
            }

            if (Sender.Withdraw(Amount))
            {
                Receiver.Deposit(Amount);
                IsSuccessful = true;
                Console.WriteLine("Transfer process completed successfully.");
                PrintReceipt();
            }
            else
            {
                Console.WriteLine("Transfer failed. Please check sender's balance.");
            }
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"\n--- Transaction Receipt ---");
            Console.WriteLine($"Transaction ID: {TransactionId}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Sender: {Sender.AccountNumber} ({Sender.HolderName})");
            Console.WriteLine($"Receiver: {Receiver.AccountNumber} ({Receiver.HolderName})");
            Console.WriteLine($"Amount: {Amount:C}");
            Console.WriteLine($"Status: {(IsSuccessful ? "Completed" : "Failed")}");
            Console.WriteLine("---------------------------");
        }
    }
}
