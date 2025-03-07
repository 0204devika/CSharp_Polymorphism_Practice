using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//definition
//Compile Time polymorphism :- Method overloading
//method overloading :- Same method name in same class with different parameters
namespace Poly_Practice
{
    class Compile_time_poly
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a,int b,int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
}
