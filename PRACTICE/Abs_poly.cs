using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_Practice
{
    public abstract class Abs_poly
    {
        public virtual void Display()
        {

        }
    }
    public class First_child_class : Abs_poly
    {
        public override void Display()
        {
            Console.WriteLine("Hello from First child class");
        }
    }
    public class Second_child_class : Abs_poly
    {
        public override void Display()
        {
            Console.WriteLine("Hello from Second child class");
        }
    }

}
