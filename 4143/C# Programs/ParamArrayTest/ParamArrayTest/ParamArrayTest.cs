// Exercise 8.14 Solution: ParamArrayTest.cs
// Using variable-length argument lists.
using System;

public class ParamArrayTest
{
   // multiply numbers
   public static int Product( params int[] numbers )
   {
      int product = 1;

      // process variable-length argument list
      foreach ( int number in numbers )
         product *= number;

      return product;
   } // end method Product

   public static void Main( string[] args )
   {
      // values to multiply
      int a = 1;
      int b = 2;
      int c = 3;
      int d = 4;
      int e = 5;

      // display integer values
      Console.WriteLine( "a = {0}, b = {1}, c = {2}, d = {3}, e = {4}\n",
         a, b, c, d, e );

      // call product with different number of arguments in each call
      Console.WriteLine( "The product of a and b is: {0}",
         Product( a, b ) );
      Console.WriteLine( "The product of a, b and c is: {0}",
         Product( a, b, c ) );
      Console.WriteLine( "The product of a, b, c and d is: {0}",
         Product( a, b, c, d ) );
      Console.WriteLine( "The product of a, b, c, d and e is: {0}",
         Product( a, b, c, d, e ) );

      // Keep the console window open in debug mode.
      Console.WriteLine("\nPress any key to exit.");
      Console.ReadKey();
   } // end Main
} // end class ParamArrayTest

/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
