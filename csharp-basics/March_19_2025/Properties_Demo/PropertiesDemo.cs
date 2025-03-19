using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_basics.March_19_2025.Properties_Demo
{
    class PropertiesDemo
    {
        
        public PropertiesDemo() { 
            Employee emp = new Employee();
            //emp._employeeID = 100; //We cannot access the private data members
            //So, using public properties (SET Accessor) we are setting 
            //the values of private data members
            emp.EmployeeID = 100;
            emp.EName = "Vishwjeet Ujgare";

            //Using public properties (Get Accessor) we are Getting 
            //the values of private data members
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee id:" + emp.EmployeeID);
            Console.WriteLine("Employee name:" + emp.EName);
         

            Student student = new Student();
            student.StudentMbl = "9898989898";
            student.StudentName = "jeet";

            student.Age = 23;

            Console.WriteLine();
            Console.WriteLine("Student Name : " + student.StudentName);
            Console.WriteLine("Student Mobile number : " + student.StudentMbl);
            //Auto impletement properties
            Console.WriteLine("Accessing auto implment properties : " + student.Age);





        }


    }
}
