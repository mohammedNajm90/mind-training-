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

            Book book = new Book("Learn how to code", "Moosa", 100);
            Console.WriteLine(book.get_discounted_price(20));

            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct("bread", 1000);
            cart.AddProduct("milk", 1500);
            Console.WriteLine(cart.TotalPrice());
            cart.RemoveProduct("milk");
            Console.WriteLine(cart.TotalPrice());


        }
    }
}
