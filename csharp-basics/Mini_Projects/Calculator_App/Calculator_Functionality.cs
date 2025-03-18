
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.Mini_Projects.Calculator_App
{
    
    class Calculator_Functionality
    {

      

         private decimal ActualNum1 = 0;
         private decimal ActualNum2 = 0;
        

        public bool TakeValuesFromUser() {
            Console.WriteLine("\n\n=========Enter Your Values===========");
           
            Console.Write("Enter  Number 1 : ");
            string input1=Console.ReadLine();
         
       

                      
            Console.Write("Enter  Number 2 : ");
            string input2 = Console.ReadLine();

            bool isConverted1 = decimal.TryParse(input1, out decimal number1);
            bool isConverted2 = decimal.TryParse(input2, out decimal number2);

            if (!(isConverted1 && isConverted2))
            {
                return false;
            }


            ActualNum1 = number1;
            ActualNum2 = number2;

            return true;

        }



        public bool SelectOperation() {
            DisplayAvailableOperations();
            Console.WriteLine("---------------------------------");
            Console.Write("Enter Option(1/2/3/4/5/6) : ");
           
            bool isConvertedToInt=int.TryParse(Console.ReadLine(), out int option);
            if (!isConvertedToInt) {
                return false;
            }

            if (option < 1 || option > 6)
            {
                Console.WriteLine("Invalid Option Selected");
                return false;
            }



            return PerformOperation(option);

        }


        public bool PerformOperation(int opt) {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("                ANS               ");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            decimal result = 0.0m;
           
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Addition Operation Selected");
                     result = ActualNum1 + ActualNum2;
                    Console.WriteLine($"Addition of {ActualNum1} and {ActualNum2} is {result}");
                    break;  
                case 2:
                    Console.WriteLine("Substraction Operation Selected");
                     result = ActualNum1 - ActualNum2;
                    Console.WriteLine($"Substraction of {ActualNum1} and {ActualNum2} is {result}");

                    break;
                case 3:
                    Console.WriteLine("Multiplication Operation Selected");
                    result = ActualNum1 * ActualNum2;
                    Console.WriteLine($"Multiplication of {ActualNum1} and {ActualNum2} is {result}");

                    break;
                case 4:
                    Console.WriteLine("Division Operation Selected");
                    if (PerformDivisionOperation())
                    {
                        result = ActualNum1 / ActualNum2;
                        Console.WriteLine($"Division of {ActualNum1} and {ActualNum2} is {result}");
                    }
                   
                    break;
                case 5:
                    Console.WriteLine("You select option to enter diff inputs");
                    Calculator_App.requestForNewCalculation = true;
                    return false;
                case 6:
                    Console.WriteLine("Exit Operation Selected");
                    return false;
                    
            }

            
            return true;

        
        }

        public bool PerformDivisionOperation() {
            if (ActualNum2 == 0.0M)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Error : Division by zero is not allowed");
                return false;
            }
            return true;
        }


        public void DisplayAvailableOperations() {
            Console.WriteLine("---------------------------------\n\n");
            Console.WriteLine("Select Your Operation From Available List : ");
            Console.WriteLine("1. Addition (+) ");
            Console.WriteLine("2. Substraction (-) ");
            Console.WriteLine("3. Multiplication (*) ");
            Console.WriteLine("4. Division (/) ");
            Console.WriteLine("5. Take diff inputs");
            Console.WriteLine("6. Exit");
        }

     
        public  void  DisplayNumbers(decimal num1, decimal num2) {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Your entered number are {num1} and {num2}");
        }




    }
}
