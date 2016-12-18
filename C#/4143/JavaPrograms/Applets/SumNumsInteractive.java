//SumNumsInteractive.java
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.applet.Applet;


//Tell the applet you will be using the ActionListener methods
public class SumNumsInteractive extends Applet implements ActionListener {
	
	TextField text1, text2;
	
	//add components to the applet
	public void init()
	{
	    //initialize GUI components and add to the applet
		text1 = new TextField(10);
		text2 = new TextField(10);
		text1.setText("0");
		text2.setText("0");
		add(text1);
		add(text2);
		
		//add listeners for the text fields to this applet
		text1.addActionListener(this);
		text2.addActionListener(this);
	} //end init
	
	public void paint(Graphics g) 
	{
		int num1 = 0;
		int num2 = 0;
		int sum;
		String s1, s2, s3;

		g.drawString("Input a number in each box ", 10, 50);
		try 
		{
			s1 = text1.getText();
			num1 = Integer.parseInt(s1);
			s2 = text2.getText();
			num2 = Integer.parseInt(s2);
			
		    sum = num1 + num2;
		    String str = "THE SUM IS: "+ sum;
  		   g.drawString (str,100, 125);
		}
		catch(Exception e1) 
		{
		}
	} //end paint


    @Override
    public void actionPerformed(ActionEvent actionEvent) {
        repaint();
    }
}