using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.Console_Methods_Props
{
    class PropertiesOfConsole
    {
        public void SetConsoleProperties() {
            string title = "Vishwjeet Ujgare";

            Console.WriteLine("THis is default setting of cosole");
            EnterKeyToProceed();

            Console.Title = title;
            Console.WriteLine("Hope you can see title bar has changed to "+title);
            
            EnterKeyToProceed();

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Background color has changed to white");

            EnterKeyToProceed();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Background color has changed to default black");

            EnterKeyToProceed();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Font color changed to blue");

            EnterKeyToProceed();

            int windowLen = Console.LargestWindowWidth;

   

            Console.CursorSize = 100;
            Console.WriteLine("Coursor Size is  30");

            EnterKeyToProceed();

        }

        void EnterKeyToProceed() {
            Console.Write("\nEnter any key to proceed :");
            Console.ReadKey();
        }
    }
}
