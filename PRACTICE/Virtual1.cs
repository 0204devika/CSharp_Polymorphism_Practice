using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//if a base class is not marked virtual, then it is not possible to override it in derived class
//without using virtual in base class, if derived class uses defines a method with same name, then it is considered as a new method.
namespace Poly_Practice
{
    public class Virtual1
    {
        public void Display()
        {
            Console.WriteLine("Hello from parent class");
        }
    }
    public class Chile_Class1 : Virtual1
    {
        public void Display()
    {
        Console.WriteLine("Hello from child class");
    }
}
}
