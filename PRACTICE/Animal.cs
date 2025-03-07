using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The output will be "Dog Barks".
//Because, the speak method is overriden in the derived class.
namespace Poly_Practice
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog_3 : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }

    }
}
