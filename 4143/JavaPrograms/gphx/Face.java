import java.awt.*;
import java.applet.*;

public class Face extends Applet
{
        public void paint(Graphics g)
        {
                g.drawOval(40,40,120,150);  	//Head
                g.drawOval(57,75,30,20);    		//Left eye
                g.drawOval(110,75,30,20);   		//Right eye
                g.fillOval(68,81,10,10);    		//Pupil (left)
                g.fillOval(121,81,10,10);   		//Pupil (right)
                g.drawOval(85,100,30,30);   		//Nose
                g.fillArc(60,125,80,40,180,180);  	//Mouth
                g.drawOval(25,92,15,30);    		//Left ear
                g.drawOval(160,92,15,30);               //Right ear
        }
}
