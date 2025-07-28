using System;


namespace OOPExcercises
{
    public class Car
    {
        public String Brand { get; protected set; }
        public String Model { get; protected set; }
        public int Year { get; protected set; }

        public Car (String brand,String model,int year)
        {
            Brand = brand;
            Model = model;
            Year = year;        
        }
        
        public void Start()
        {
            Console.WriteLine("Car " + Brand + " Started");
        }

        public void Stop()
        {
            Console.WriteLine("Car " + Brand + " Stoped");
        }
    }
}
