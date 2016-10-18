   // Circle2 inherits from class Point2
   public class Circle2 extends Point2 
   {

      private double radius; // Circle2 radius

      // default constructor
      public Circle2()
      {
         // implicit call to Point2 constructor occurs here
      }

      // constructor
      public Circle2( int xValue, int yValue, double radiusValue )
      {
		  super (xValue, yValue);
		  radius = radiusValue;
      }

      // property Radius
      public double getRadius ()
      {
 
            return radius;
      }

      public void setRadius(double value)
      {
         // ensure non-negative radius value
          if ( value >= 0 )
               radius = value;
      }

      // calculate Circle2 diameter
      public double Diameter()
      {
         return radius * 2;
      }

      // calculate Circle2 circumference
      public double Circumference()
      {
         return Math.PI * Diameter();
      }

     // calculate Circle2 area
      public double Area()
      {
         return Math.PI * radius*radius;
      }
	  
      // return string representation of Circle2 object
      public String ToString()
      {
         return "Center = " + super.ToString() + "; Radius = " + radius;
      }

      // override property Name from class Shape
      public String Name ()
      {
            return "Circle2";
      }
   } // end class Circle2
