using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Run-time polymorphism :- Method overriding
//Method overriding :- Same method with same parameters in parent and child class.
namespace Poly_Practice
{
    public class Run_time_poly
    {
        public virtual void Makesound()
        {
            Console.WriteLine("Sound!!!");
        }
    }
    class Dog_1 : Run_time_poly
    {
        public override void Makesound()
        {
            Console.WriteLine("Bow Bow!!!");
        }
    }
    class Cat_1 : Run_time_poly
    {
        public override void Makesound()
        {
            Console.WriteLine("Meow!!!");
        }
    }
}
