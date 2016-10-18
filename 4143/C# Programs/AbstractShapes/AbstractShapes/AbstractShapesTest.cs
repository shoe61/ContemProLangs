// AbstractShapesTest.cs
// Demonstrates polymorphism in Point-Circle-Cylinder hierarchy.
using System;
using System.Windows.Forms;
using AbstractShapesLibrary;


   public class AbstractShapesTest
   {
      public static void Main( string[] args )
      {
         // instantiate Point2, Circle2 and Cylinder2 objects
         Point2 point = new Point2( 7, 11 );
         Circle2 circle = new Circle2( 22, 8, 3.5 );
         Cylinder2 cylinder = new Cylinder2( 10, 10, 3.3, 10 );

         // create empty array of Shape base-class references
         Shape shape;

         // shape refers to Circle2 object
         shape= circle;

         string output = point.Name + ": " + point + "\n" +
            circle.Name + ": " + circle + "\n" +
            cylinder.Name + ": " + cylinder;

         // display Name, Area and Volume for shape (circle)
         //  polymorphically
           output += "\n\n" + shape.Name + ": " + shape +
               "\nArea = " + shape.Area().ToString( "F" ) + 
               "\nVolume = " + shape.Volume().ToString( "F" );

		  //shape now refers to Cylinder2 object
		  shape = cylinder;
		  
		  // display Name, Area and Volume for shape (circle)
		  //  polymorphically
		  output += "\n\n" + shape.Name + ": " + shape +
			  "\nArea = " + shape.Area().ToString( "F" ) + 
			  "\nVolume = " + shape.Volume().ToString( "F" );


         MessageBox.Show( output, "Demonstrating Polymorphism" );          
      }
   }

