/**
   @version 1.1 2004-02-21
   @author Cay Horstmann
*/

import java.util.*;

public class ArrayListTest
{  
   public static void main(String[] args)
   {  
      ArrayList <Point> list = new ArrayList<Point> ();
      Point p = new Point (0, 4);

      for (int i = 0; i < 10; i++)
          list.add (p);

      Point[] pts = new Point[list.size()];
      int cnt = 0;
      for (Point q: list)
      {
         pts[cnt] = q;
         cnt++;
      }
      
      
      System.exit(0);
   }
}

class Point
{
        public Point (int x, int y)
        {
           this.x = x;  this.y = y;
        }

        private int x;
        private int y;
}


  