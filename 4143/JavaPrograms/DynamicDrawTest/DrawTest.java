/**READ PAGES 416-417
   @version 1.31 2004-05-03
   @author Cay Horstmann
*/

import java.awt.*;
import java.awt.geom.*;
import javax.swing.*;
import java.awt.event.*;    //NEW


public class DrawTest
{  
   public static void main(String[] args)
   {
	  ActionFrame frame = new ActionFrame();
	  frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
   }
}

/**
   A frame that contains a panel with drawings
*/
class ActionFrame extends JFrame
{
   public ActionFrame()
   {
      setTitle("Action DrawTest");
      setSize(DEFAULT_WIDTH, DEFAULT_HEIGHT);

      // add panel to frame
      DrawPanel panel = new DrawPanel();
      add(panel);
	  setVisible(true);    //MOVED THIS HERE FROM MAIN

	  panel.draw();		   //CALL NEW METHOD IN DRAWPANEL
   }

   public static final int DEFAULT_WIDTH = 600;
   public static final int DEFAULT_HEIGHT = 400;  
}

/**
   A panel that displays rectangles and ellipses. 
*/
class DrawPanel extends JPanel
{
   public void draw()         //NEW METHOD
   {

	   rect = new Rectangle2D.Double(leftX, topY, width, height);
	   ellipse = new Ellipse2D.Double();
	   ellipse.setFrame(rect);

	   
	   try
	   {   //animate
		   for (int i = 0; i < 100; i++)
		   {
			   rect = new Rectangle2D.Double(leftX, topY, width, height);
			   double k;
			   repaint();		   //TRIGGERS PAINTCOMPONENT EVENT
			   Thread.sleep(100);  //may attempt to throw an exception
			   leftX += 1;
		   }
	   }
	   catch (InterruptedException e)
	   {
	   }
   }

   public void paintComponent(Graphics g)
   {  
      super.paintComponent(g);
      Graphics2D g2 = (Graphics2D) g;

      // draw a rectangle
      g2.draw(rect);
    
      // draw the ellipse
      g2.draw(ellipse);
     
   }

  //GLOBAL CONSTANTS OKAY
   public final static double topY = 100;
   public final static double width = 200;
   public final static double height = 150;   
	
   //CLASS VARIABLES, OKAY BECAUSE NOT MAIN CLASS VARIABLES
   private double leftX = 100;
   private Rectangle2D rect;
   private Ellipse2D ellipse;
}
