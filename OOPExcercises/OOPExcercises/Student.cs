using System;


namespace OOPExcercises
{
    public class Student
    {
        public String Name { get; protected set; }
        public int Age { get; protected set; }
        public int Grade { get; protected set; }

        public Student (String name,int age,int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void Introduce()
        {
            Console.WriteLine("The Student: " + Name + " which his/her age: "+ Age + " and his/her grade: "+ Grade);
        }
    }
}
