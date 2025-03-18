using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.Mini_Projects.Calculator_App
{
    class Calculator_App
    {
        public static bool wantToExit = false;
        public static bool requestForNewCalculation = false;
        public Calculator_App() {


         
                CalculatorApplicationView calAppView = new CalculatorApplicationView();
                calAppView.CalWelcomeMsg();
                calAppView.ModifyConsoleView();

                Calculator_Functionality calFun = new Calculator_Functionality();

            do
            {
                requestForNewCalculation = false;

      

                while (!calFun.TakeValuesFromUser())
                {
                    Console.WriteLine($"Only Numbers(Decimal Or Integer) are allowed\n");

                }

               bool  takeValuesFromUserTill = calFun.SelectOperation();

                while (takeValuesFromUserTill)
                {

                    takeValuesFromUserTill = calFun.SelectOperation();

                }



            } while (requestForNewCalculation);


            calAppView.DisplayExistMessage();


        }
    }
}
