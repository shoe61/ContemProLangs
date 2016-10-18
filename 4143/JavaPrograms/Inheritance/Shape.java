// Fig. 10.4: Shape.java
// Demonstrate a shape hierarchy using an abstract base class.

   public abstract class Shape
   {
	   String name;

	   //default constructor
	   public Shape ()
	   {
		   name = "Shape";
	   }

      // return Shape's area
      public  double Area()
      {
         return 0;
      }

      // return Shape's volume
      public  double Volume()
      {
         return 0;
      }

      // return Shape's name
      public  String Name()
      {
         return name;
      }

	   public String ToString()
	   {
		   return name;
	   }
   }
