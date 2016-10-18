/**
   @version 1.30 1999-12-21
   @author Cay Horstmann
*/

import javax.swing.*;

public class SimpleFrameTest2
{  
   public static void main(String[] args)
   {  
      SimpleFrame frame = new SimpleFrame();
      frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	  frame.setVisible(true);  
   }
}

class SimpleFrame extends JFrame
{
   public SimpleFrame()
   {
      setBounds(100, 100, DEFAULT_WIDTH, DEFAULT_HEIGHT );
      setTitle ("My title is Frame");
	  setResizable (false);
   }

   public static final int DEFAULT_WIDTH = 300;
   public static final int DEFAULT_HEIGHT = 200;
}

