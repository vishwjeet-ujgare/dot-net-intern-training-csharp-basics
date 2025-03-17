using csharp_basics.Caller_Class;
using csharp_basics.Data_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            CallerClass cc= new CallerClass();
            //Method are committed in CallerClass go and uncommited one by one
            cc.CallDataTypes();
            cc.CallConsoleMethodsProperties();

        }
    }
}
