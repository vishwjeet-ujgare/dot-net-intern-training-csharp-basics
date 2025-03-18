using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.Mini_Projects.Calculator_App
{
    class CalculatorApplicationView
    {
        public CalculatorApplicationView() {
          
        }

        public void CalWelcomeMsg() {
            Console.WriteLine("\n================================================");
            Console.WriteLine(" Welcome To Console-Based calculator application ");
            Console.WriteLine("       Developed By : Vishwjeet Ujgare");
            Console.WriteLine("             Date:18-March-2025       ");
            Console.WriteLine("==================================================");
        }

        public void ModifyConsoleView() {
            Console.Title = "Jeet's Calculator";
            Console.WindowWidth = 53;

        }
        
        public void DisplayExistMessage() {
            Console.WriteLine("\n===============================================");
            Console.WriteLine("    Thank you for using the Jeet's Calculator!    ");
            Console.WriteLine("==================================================");
        }


    }
}
