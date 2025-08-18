using System;

namespace Bank
{
    public class Employee
    {
        public string EmployeeId { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Employee(string username, string password)
        {
            EmployeeId = Guid.NewGuid().ToString();
            Username = username;
            Password = password;
        }

        public void CreateNewAccount(Bank bank, string accNum, string name, string pass)
        {
            if (bank.FindAccount(accNum) != null)
            {
                Console.WriteLine("Error: Account with this number already exists.");
                return;
            }
            Account newAccount = new Account(accNum, name, pass);
            bank.Accounts.Add(newAccount);
            Console.WriteLine("Account created successfully!");
        }

        public void CreateNewEmployee(Bank bank, string newUsername, string newPassword)
        {
            if (bank.FindEmployee(newUsername) != null)
            {
                Console.WriteLine("Error: Employee with this username already exists.");
                return;
            }
            Employee newEmployee = new Employee(newUsername, newPassword);
            bank.Employees.Add(newEmployee);
            Console.WriteLine("Employee created successfully!");
        }
    }
}
