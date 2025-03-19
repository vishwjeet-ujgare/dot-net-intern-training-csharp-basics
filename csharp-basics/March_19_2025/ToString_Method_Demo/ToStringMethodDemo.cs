using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.March_19_2025.ToString_Method_Demo
{
    public class Employee
    {
        public string FirstName;
        public string LastName;


        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }
    }


    class ToStringMethodDemo
    {
        public ToStringMethodDemo() {
            int number = 10;
            Console.WriteLine(number.ToString());

            Employee emp = new Employee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            Console.WriteLine(emp.ToString());
         
        }
    }
}
