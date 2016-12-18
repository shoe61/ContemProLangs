import javax.swing.*;
import java.awt.*;

/**
 * @version 1.32 2007-06-12
 * @author Cay Horstmann
 */
public class HelloWorld
{
   public static void main(String[] args)
   {
      EventQueue.invokeLater(new Runnable()
         {
            public void run()
            {
               HelloWorldFrame frame = new HelloWorldFrame();
               frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
               frame.setVisible(true);
            }
         });
   }
}

/**
 * A frame that contains a message panel
 */
class HelloWorldFrame extends JFrame
{
   public HelloWorldFrame()
   {
      setTitle("HelloWorld");
      setSize(DEFAULT_WIDTH, DEFAULT_HEIGHT);

      // add panel to frame

      HelloWorldPanel panel = new HelloWorldPanel();
      add(panel);
   }

   public static final int DEFAULT_WIDTH = 300;
   public static final int DEFAULT_HEIGHT = 200;
}

/**
 * A panel that displays a message.
 */
class HelloWorldPanel extends JPanel
{
   public void paintComponent(Graphics g)
   {
      g.drawString("A Hello, World program", MESSAGE_X, MESSAGE_Y);
   }

   public static final int MESSAGE_X = 75;
   public static final int MESSAGE_Y = 100;
}
