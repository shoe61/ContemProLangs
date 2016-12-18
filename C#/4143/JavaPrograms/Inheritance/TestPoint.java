// Test Poinktc class
import javax.swing.JOptionPane;

   public class TestPoint
   {
      public static void main( String[] args )
{
         // instantiate Point object
         Point2 point = new Point2( 72, 115 );
   
         // display point coordinates via X and Y properties
         String output = "X coordinate is " + point.getX() +
            "\n" + "Y coordinate is " + point.getY();
   
         point.setX(10); // set x-coordinate 
         point.setY(10); // set y-coordinate 
   
         // display new point value
         output += "\n\nThe new location of point is " + point.ToString();
   
         JOptionPane.showMessageDialog(null, "Demonstrating Class Point\n\n" + output );
         } // end method Main

   }

