using System;


namespace OOPExcercises
{
    public class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public Calculator (int number1,int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public void Add()
        {
            Console.WriteLine($"{Number1} + {Number2} = { Number1 + Number2}");
        }
        public void Subtract()
        {
            Console.WriteLine($"{Number1} - {Number2} = { Number1 - Number2}");
        }
        public void Multiply()
        {
            Console.WriteLine($"{Number1} * {Number2} = { Number1 * Number2}");
        }
        public void Divide()
        {
            Console.WriteLine($"{Number1} / {Number2} = { Number1 / Number2}");
        }
    }
}
