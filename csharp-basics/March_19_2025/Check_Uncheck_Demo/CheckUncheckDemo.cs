using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.March_19_2025.Check_Uncheck_Demo
{
    class CheckUncheckDemo
    {

        public CheckUncheckDemo() {

            DefaultCUBehaviour();

            Console.WriteLine("Uncommet checked exception demo method");
            //UnderstandCheckedKeyWord();
            UnderstandUncheckedKeyWord();

        }


        public void DefaultCUBehaviour()
        {

            int a = 2147483647; // max value for int type 
            int b = 2147483647;//max value for int type
            int c = a + b;

            Console.WriteLine("================Default behaviour=============");
            Console.WriteLine($"Addition of int {a} + {b} = {c}");
         
        }

        public void UnderstandCheckedKeyWord()
        {
            int a = 2147483647; // max value for int type 
            int b = 2147483647;//max value for int type
            int c = 0;

            c = checked(a + b);


            Console.WriteLine("================Checked behaviour=============");
            Console.WriteLine($"Addition of int {a} + {b} = {c}");

        }

        public void UnderstandUncheckedKeyWord()
        {
            int a = 2147483647; // max value for int type 
            int b = 2147483647;//max value for int type
            int c = 0;

            c = unchecked(a + b);


            Console.WriteLine("================Unchchecked behaviour=============");
            Console.WriteLine($"Addition of int {a} + {b} = {c}");

        }

    }
}
