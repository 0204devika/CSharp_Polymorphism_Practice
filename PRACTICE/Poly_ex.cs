using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Polymorphism :- Ability of an object to take many forms. 
//Compile time polymorphism :- Method overloading
//Run time polymorphism :- Method overriding
//Method overloading :- Same method name in same class with different parameters
//Mthod overriding :- Same method with same parameters in parent and child class.
namespace Poly_Practice
{
    public class Poly_ex
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public virtual void Makesound()
        {
            Console.WriteLine("Sound!!!");
        }
    }
    public class Dog : Poly_ex
    {
        public override void Makesound()
        {
            Console.WriteLine("Bark!!!");
        }
    }
    public class Cat : Poly_ex
    {
        public override void Makesound()
        {
            Console.WriteLine("Meow!!!");
        }
    }
}
