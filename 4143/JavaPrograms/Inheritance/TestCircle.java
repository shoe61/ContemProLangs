// Test Point and Circle classes
import javax.swing.JOptionPane;

   public class TestCircle
   {
      public static void main( String[] args )
{
     // instantiate Circle
         Circle2 circle = new Circle2( 37, 43, 2.5 );
   
         // get Circle's initial x-y coordinates and radius
         String output = "X coordinate is " + circle.getX() + 
            "\nY coordinate is " + circle.getY() + "\nRadius is " +
            circle.getRadius ();
   
         // set Circle's x-y coordinates and radius to new values
        circle.setX(2);      circle.setY( 2);   circle.setRadius (4.25);
   
         // display Circle's string representation
         output += "\n\nThe new location and radius of " +
            "circle are \n" + circle.ToString() + "\n";
   
         // display Circle's diameter
         output += "Diameter is " + circle.Diameter()  + "\n";

         // display Circle's circumference
         output += "Circumference is " + circle.Circumference()  + "\n";
   
         // display Circle's area
         output += "Area is " +  circle.Area() ;

		 JOptionPane.showMessageDialog(null, "Demonstrating Circle Point\n\n" + output );
         
         } // end method Main

   }

