import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

  public class ButtonFrame extends JFrame
   {
		private JPanel p;
		private JButton b;
		public static final int DEFAULT_WIDTH = 300;
		public static final int DEFAULT_HEIGHT = 200;
	   
		public ButtonFrame()
		{
			setTitle("HelloWorld");
			setSize(DEFAULT_WIDTH, DEFAULT_HEIGHT);
	  	  	setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			
			p = new JPanel();
			
			b = new JButton("press me");
	  		b.addActionListener(new MyButtonAction());
	  
			p.add(b);		     // add button to panel
			setContentPane(p);    // add panel to frame
 		}		  
		
		//inner class
		private class MyButtonAction implements ActionListener
		{
			public void actionPerformed(ActionEvent event)
			{
				//do whatever action you want
				b.setText("don't press me");
			}
		
		}
   }