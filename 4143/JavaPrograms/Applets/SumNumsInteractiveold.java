//SumNumsInteractive.java
import java.applet.Applet;
import java.awt.*;

public class SumNumsInteractive extends Applet {
	TextField text1, text2;
	public void init()
	{
		text1 = new TextField(10);
		text2 = new TextField(10);
		text1.setText("0");
		text2.setText("0");
		add(text1);
		add(text2);
	}
	public void paint(Graphics g) {
		int num1 = 0;
		int num2 = 0;
		int sum;
		String s1, s2, s3;

		g.drawString("Input a number in each box ", 10, 50);
		try {
			s1 = text1.getText();
			num1 = Integer.parseInt(s1);
			s2 = text2.getText();
			num2 = Integer.parseInt(s2);
		        sum = num1 + num2;
		        String str = "THE SUM IS: "+String.valueOf(sum);
  		        g.drawString (str,100, 125);
		}

		catch(Exception e1) {
		}
	}

	public boolean action(Event ev, Object obj)
	{
		repaint();
		return true;
	}
}
