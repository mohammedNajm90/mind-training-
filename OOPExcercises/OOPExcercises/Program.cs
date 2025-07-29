using System;

namespace OOPExcercises
{
    class Program
    {
        private static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "x6", 2025);
            Car car2 = new Car("Toyota", "Camry", 2020);
            Car car3 = new Car("Hyndai", "Elentra", 2018);

            car1.Start();
            car1.Stop();

            car2.Start();
            car2.Stop();

            car3.Start();
            car3.Stop();

            Student student = new Student("Ali", 20, 90);
            student.Introduce();

            Rectangle rectangle = new Rectangle(2, 4);
            Console.WriteLine("rectangle area is " + rectangle.area());
            Console.WriteLine("rectangle perimeter is " + rectangle.perimeter());

            BankAccount bankAccount = new BankAccount(100.00);
            Console.WriteLine(bankAccount.Balance);
            bankAccount.Deposit(20.00);
            Console.WriteLine(bankAccount.Balance);

            Book book1 = new Book("Learn how to code", "Moosa", 100);
            Book book2 = new Book("Learn English", "Ali", 150);
            Console.WriteLine(book1.get_discounted_price(20));

            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct("bread", 1000);
            cart.AddProduct("milk", 1500);
            Console.WriteLine(cart.TotalPrice());
            cart.RemoveProduct("milk");
            Console.WriteLine(cart.TotalPrice());

            Square shape = new Square(5.0);
            Console.WriteLine(shape.Area());

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.ShowBooks();
            library.RemoveBook("Learn English");
            library.ShowBooks();

            Employee employee = new Employee("Ahmed",27,1000);
            employee.greet();

            Calculator calculator = new Calculator(9, 3);
            calculator.Add();
            calculator.Subtract();
            calculator.Multiply();
            calculator.Divide();

        }
    }
}
