import javax.swing.*;
import java.awt.*;

public class PanelTest
{  
   public static void main(String[] args)
   {  
      MessageFrame frame = new MessageFrame();
      frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      frame.show();
   }
}

/**
   A frame that contains a message panel
*/
class MessageFrame extends JFrame
{
   public MessageFrame()
   {
      setTitle("Not Hello World");
      setSize(DEFAULT_WIDTH, DEFAULT_HEIGHT);

      // add panel to frame
      MessagePanel panel = new MessagePanel();
      Container contentPane = getContentPane();
      contentPane.add(panel);
   }

   public static final int DEFAULT_WIDTH = 300;
   public static final int DEFAULT_HEIGHT = 200;  
}

/**
   A panel that displays a message. 
*/
class MessagePanel extends JPanel
{  
   public void paintComponent(Graphics g)
   {  
      super.paintComponent(g);

      g.drawString("Java Programming is COOL!", 
         MESSAGE_X, MESSAGE_Y);
   }

   public static final int MESSAGE_X = 75;
   public static final int MESSAGE_Y = 100;
}



