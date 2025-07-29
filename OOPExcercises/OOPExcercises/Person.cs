using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExcercises
{
    public class Person
    {
        public String Name { get; protected set; }
        public int Age { get; protected set; }

        public Person (String name, int age){
            Name = name;
            Age = age;
            }
        public void greet()
        {
            Console.WriteLine($"Welcome {Name} ");
        }
    }
    public class Employee : Person
    {
        public double Salary { get; set; }

        public Employee(string name, int age, double salary) : base(name, age)
        {
            Salary = salary;
        }

        public void ShowSalary()
        {
            Console.WriteLine($"My salary is {Salary}");
        }
    }
}
