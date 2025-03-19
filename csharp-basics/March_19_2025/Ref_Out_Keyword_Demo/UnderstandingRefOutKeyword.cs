using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.March_19_2025.Ref_Out_Keyword_Demo
{
    class UnderstandingRefOutKeyword
    {

//Call By Value in C#:
    //In Call by Value, the copy of the original variable is passed to the called function.
    //In Call by Value, the value of the original parameter is copied into the parameter of the function.As a result, if we make any modifications to formal parameters, they don’t have any impact on the actual parameter.
    //It will not allow you to change the actual variables using function calls.
    //The memory location referred to by formal parameters and actual arguments is different.
    //It doesn’t require a ref or out keyword in C#.


//Call By Reference in C#:
    //In Call by Reference, the variable’s reference(or the actual address) is passed to the called function.
    //    In Call by Reference, the formal and actual parameters point to the same memory address.As a result, any changes made to the formal parameters are also reflected in the actual parameters.
    //    It allows you to change the actual variable’s value using function calls.
    //    The memory location referred to by formal parameters and actual arguments are the same.
    //    It requires a ref or out keyword to achieve Call By Reference in C#.
        public UnderstandingRefOutKeyword()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("==================Values===================");
            Console.WriteLine($"Before calling the method a = {a} and b = {b}");
            CallByValue(a, b);
            Console.WriteLine($"After calling the method a = {a} and b = {b}");
            
            Console.WriteLine("==================REF===================");
            
            Console.WriteLine($"Before calling the method a = {a} and b = {b}");
            CallByReference(ref a, ref b);
            Console.WriteLine($"After calling the method with ref a = {a} and b = {b}");
            
            
            Console.WriteLine("==================OUT===================");
          
            
            int sum = 0;
            int product = 0;
            Console.WriteLine($"Before calling the method sum = {sum} and product = {product}");
            CallByReferenceOut(out sum, out product);
            Console.WriteLine($"After calling the method sum = {sum} and product = {product}");

        }

        public void CallByValue(int a, int b)
        {
            a = a + 10;
            b = b + 20;
            Console.WriteLine($"Inside the method a = {a} and b = {b}");
        }

        public void CallByReference(ref int a, ref int b)
        {
            a = a + 10;
            b = b + 20;
            Console.WriteLine($"Inside the method a = {a} and b = {b}");
        }

        public void CallByReferenceOut(out int sum, out int product)
        {
            sum = 10 + 20;
            product = 10 * 20;
            Console.WriteLine($"Inside the method sum = {sum} and product = {product}");
        }
    }
}
