/*Scott Schumacher
CMPS 4143
Filename: Program.cs
Description: This C# console application prompts the user to enter three
integers. The program computes the sum of the numbers, their average, and
the largest and smallest numbers.*/

using System;

namespace Shoe_Assignment_2
{
    class Program
    {
        static void Main()
        {
            //heading for output:
            Console.WriteLine("Scott Schumacher\nFilename: Assignment 2 Output\n\n");
            //Call numGetter to obtain user inputs:
            int num1 = NumGetter();
            int num2 = NumGetter();
            int num3 = NumGetter();

            //Call Adder to calcualate the sum:
            int sum = Adder(num1, num2, num3);

            //Call Avger to calculate the average:
            int average = Avger(num1, num2, num3);

            //Call Smallst to calculate the smallest number:
            int smallest = Smallst(num1, num2, num3);

            //Call Largst to calculate the largest number:
            int largest = Largst(num1, num2, num3);

            //Call OutPutter to display results to user:
            OutPutter(sum, average, smallest, largest);

        }

        static int NumGetter()
        {
            //prompt user
            Console.Write("Please enter an integer: ");
            //read input and convert from string to integer
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int Adder(int op1, int op2, int op3)
        {
            int result = op1 + op2 + op3;
            return result;
        }

        static int Avger(int op1, int op2, int op3)
        {
            int mean = (op1 + op2 + op3) / 3;
            return mean;
        }

        static int Smallst(int op1, int op2, int op3)
        {
            //
            int least = op1;
            if (least > op2)
            {
                least = op2;
            }
            if (least > op3)
            {
                least = op3;
            }
            return least;
        }

        static int Largst(int op1, int op2, int op3)
        {
            int greatest = op1;
            if (greatest < op2)
            {
                greatest = op2;
            }
            if (greatest < op3)
            {
                greatest = op3;
            }
            return greatest;
        }

        static void OutPutter(int sum, int average, int smallest, int largest)
        {
            
            Console.WriteLine("\n\nThe sum is {0}.", sum);
            Console.WriteLine("\nThe average is {0}.", average);
            Console.WriteLine("\nThe smallest number is {0}.", smallest);
            Console.WriteLine("\nThe largest number is {0}.", largest);
            Console.Read();
        }
    }

}
