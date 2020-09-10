using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degubber // <-- fix this so that it says Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            DebugMePlease;
        }
        

        static void DebugMePlease()
        {
            // <-- Slashes are for comments
            /*

            //Common Data Types
            int myInt = 1347; 
            char myChar = 'XYZ'; 
            float myFloat = 75.32F; 
            double myDouble = 123.456789012345; 
            decimal myDecimal = 1234567890.1234567890123456789012345678901234567890; 
            boolean myBool = true; 
            string myString = "Hi. This is just some random text about ninjas. They're pretty awesome. 12345."; 
            */


            //Output statement should output the variables listed abve.
            Comment - This is the Output Statements
            Console.Line("myInt equals: " + myInt);
            Console.Line("myChar equals: " + myChar);
            Console.Line("myFloat equals: "  myFloat);
            Console.Line("myDouble equals: " + myDouble);
            Console.Line("myDecimal equals: " + myDecimal);
            Console.Line(myBool equals: " + myBool);
            Console.Line("myString equals: " + myString);

            //Input
            Console.ReadLine(); 
            Console.WriteLine("What is your favorite food? (Press enter when done)");
            string myNewString = Console.ReadLine();
            // Code below should output users favorite food.
            Console.WriteLine("Hey, Here's what you wrote:  + myNewString")

            //Number Inputs
            Console.WriteLine("What is your age? (Press enter when done)");
            int yourAge == Console.ReadLine();
            ConsoleWriteLine("Hey, Here's your age: " + yourAge);
        }
    }
}
