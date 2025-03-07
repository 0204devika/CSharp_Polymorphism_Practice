using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Mthod overriding :- Same method with same parameters in parent and child class
//it is also known as run-time polymorphism
//Uses :- It is used to perform different operations with same method name
//Improves code performance
//It is used to provide specific implementation of a method that is already provided by its parent class
//override keyword :- It is used to override base class method in derived class
//virtual keyword :- Used to define method in base class that can be overriden in derived class
//new keyword :- used to hide base class method in derived class
namespace Poly_Practice
{
    public class Methodoverride
    {
        public virtual void Makesound()
        {
            Console.WriteLine("Sound!!!");
        }
    }
    public class Dog_2 : Methodoverride 
    {
        public override void Makesound()
        {
            Console.WriteLine("Bow bow!!!");
        }
    }
    public class Cat_3 : Methodoverride
    {
        public override void Makesound()
        {
            Console.WriteLine("Meow!!!");
        }
    }
}
