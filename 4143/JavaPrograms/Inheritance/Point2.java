// Fig. 10.5: Point2.cs
// Point2 inherits from Shape and represents
// an x-y coordinate pair.

   // Point2 inherits from abstract class Shape
   public class Point2 
   {
      private int x, y; // Point2 coordinates

      // default constructor
      public Point2()
      {
         // implicit call to Object constructor occurs here
      }

      // constructor
      public Point2( int xValue, int yValue )
      {
         x = xValue;
         y = yValue;
      }

      // getters and setters for member data
      public int getX()
      {
              return x;
      }

       public void setX(int value)
       {
          x = value; 
       }

      public int getY()
      {
              return y;
      }

       public void setY(int value)
       {
          y = value; 
       }

      // return string representation of Point2 object
      public String ToString()
      {
         return "[" + x + ", " + y + "]";
      }

      // implement abstract property Name of class Shape
      public String Name ()
      {
            return "Point2";
      }

   } // end class Point2
