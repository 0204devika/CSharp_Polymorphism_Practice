using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Method overloading :- Same method name in same class with different parameters
//It is also known as compile time polymorphism
//Uses :- It is used to perform similar operations with different parameters
//Used for code readability
//Used for code reusability
//improves code performance
namespace Poly_Practice
{
    public class Methodoverload
    {
        public string? name { get; set; }
        public int age { get; set; }
        public string? address { get; set; }
        public int salary { get; set; }
        public void print_details(string name,int age,string address)
        {
            Console.WriteLine("Name : " + name + " Age : " + age + " Address : " + address);
        }
        public void print_details(string name, int age, string address, int salary)
        {
            Console.WriteLine("Name : " + name + " Age : " + age + " Address : " + address + " Salary : " + salary);
        }
    }
}
