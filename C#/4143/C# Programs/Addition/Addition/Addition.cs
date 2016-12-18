using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Addition
{
    class Addition
    {
        static void Main(string[] args)
        {
            string firstNumber,   // first string entered by user
            secondNumber;  // second string entered by user

            int number1,          // first number to add
              number2,          // second number to add
              sum;              // sum of number1 and number2

            // prompt for and read first number from user as string
            Console.Write( "Please enter the first integer: " );
            firstNumber = Console.ReadLine();
      
            // read second number from user as string
            Console.Write( "\nPlease enter the second integer: " );
            secondNumber = Console.ReadLine();

            // convert numbers from type string to type int
            number1 = Int32.Parse( firstNumber );
            number2 = Int32.Parse( secondNumber );
      
            // add numbers
            sum = number1 + number2;

            // display results
            Console.WriteLine( "\nThe sum is {0}.", sum );
 
        }// end method Main
    }
}
