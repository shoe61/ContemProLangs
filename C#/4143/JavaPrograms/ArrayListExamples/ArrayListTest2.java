
import java.util.*;

public class ArrayListTest2
{  
   public static void main(String[] args)
   {  
      ArrayList list = new ArrayList ();


      for (int i = 0; i < 10; i++)
          list.add (i);

      for (int i = 0; i < list.size(); i++)
	System.out.println ( list.get(i));
      
      
      System.exit(0);
   }
}




  