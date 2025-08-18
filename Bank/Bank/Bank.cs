using System;
using System.Collections.Generic;

namespace Bank
{
    public class Bank
    {
        public List<Account> Accounts { get; private set; }
        public List<Employee> Employees { get; private set; }
        public List<Transaction> Transactions { get; private set; }

        public Bank()
        {
            Accounts = new List<Account>();
            Employees = new List<Employee>();
            Transactions = new List<Transaction>();

            Employees.Add(new Employee("admin", "admin123"));
            Accounts.Add(new Account("111", "Ali Hassan", "123"));
            Accounts.Add(new Account("222", "Sara Ahmed", "456"));
        }

        public Account FindAccount(string accountNumber)
        {
            foreach (var acc in Accounts)
            {
                if (acc.AccountNumber == accountNumber) return acc;
            }
            return null;
        }

        public Employee FindEmployee(string username)
        {
            foreach (var emp in Employees)
            {
                if (emp.Username.Equals(username, StringComparison.OrdinalIgnoreCase)) return emp;
            }
            return null;
        }

        public void DeleteAccount(string accountNumber)
        {
            Account accountToDelete = FindAccount(accountNumber);
            if (accountToDelete == null)
            {
                Console.WriteLine("Error: Account not found.");
                return;
            }

            Accounts.Remove(accountToDelete);
            Console.WriteLine($"Account {accountNumber} ({accountToDelete.HolderName}) has been deleted successfully.");
        }

    }
}
