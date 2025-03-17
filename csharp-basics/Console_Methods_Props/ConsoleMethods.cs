using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace csharp_basics.Console_Methods_Props
{
    class ConsoleMethods
    {

        public void CheckOutConsoleMethods() {

            //plays the sound of a beep through the console speaker.
            Console.Beep();
            Console.WriteLine("Beep will be audible only though speaker not though headphones");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;


            Console.WriteLine("Reseting console colors to there default");
            EnterKeyToProceed();

            //ResetColor(): This method is used to set the foreground and background console colors to their defaults.
            Console.ResetColor();
            Console.WriteLine("\nReset console foreground and background colors");


            //Write(“string”): This method is used to write the specified string value to the standard output stream.
            Console.Write("Hello with Write method");


            //same as the write method but automatically moves the cursor to the next line after printing the message.
            Console.WriteLine("Hello with WriteLine method");

            //Read(): This method read a single character from the keyboard and returns its ASCII value.
            // The Datatype should be int as it returns the ASCII value.
            Console.Write("Enter any single character : ");
            int enteredAsciiValue=Console.Read();
            Console.WriteLine("Your entered " + (char)enteredAsciiValue+" ASCII value for it is : "+enteredAsciiValue);


            //ReadLine(): This method reads a string value from the keyboard and returns the entered value only.
            //    As it returns the entered string value so the DataType is going to be a string.
            Console.Write("Enter string / line : ");

            ////take care of buffer handlin
            //Console.ReadLine();
            int readInput1 = Console.Read();
            Console.Write("You entered: " + readInput1);

            int readInput2 = Console.Read();
            Console.Write("You entered: " + readInput2);

            string enteredLine = Console.ReadLine();
            Console.WriteLine("You entered: " + enteredLine);

            //ReadKey():  This method reads a single character from the keyboard and returns that character information
            //    like what key has been entered, and what its corresponding ASCII value is.
            //    The Datatype should be ConsoleKeyInfo which contains the entered key information

            Console.Write("Enter any key : ");
            ConsoleKeyInfo conKeyInfo= Console.ReadKey();
            Console.WriteLine("\nENter key info is  : "+conKeyInfo.KeyChar) ;

        }


        void EnterKeyToProceed()
        {
            Console.Write("\nEnter any key to proceed :");
            Console.ReadKey();
        }


        public void ReadLineBufferErrorDemo() {
            Console.Write("Enter a character :");
            int firstChar = Console.Read();
            Console.WriteLine("Entered character ASCII value is : " + firstChar);


            Console.Write("Enter a String : ");
            //Console.Read(); for /r
            //Console.Read();for /n
            Console.ReadLine();
            string userInput = Console.ReadLine();
            Console.WriteLine("You have entered : "+ userInput);
        }
    }
}
