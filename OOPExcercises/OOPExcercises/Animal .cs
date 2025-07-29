using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExcercises
{
    public class Animal
    {
        public virtual void  make_sound() {
            Console.WriteLine("Animal Sound");
        }
    }
    public class Dog : Animal
    {
        public override void make_sound()
        {
            Console.WriteLine("Dog Sound");
        }
    }
    public class Cow : Animal {
        public override void make_sound()
        {
            Console.WriteLine("Cow Sound");
        }
        }
    public class Cat : Animal
    {
        public override void make_sound()
        {
            Console.WriteLine("Cat Sound");
        }
    }
}
