/*  Scott Schumacher
 *  WinterPic.cs
 *  29 November 2016
 *  
 * This program demonstrates the use of drawing methods and overriding of the onPaint method.
 * I also tried to showcase the potential for animation; I'm a little disappointed that the
 * flickering persisted despite my employing doubleBuffering. 
 * 
 */

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shoe_Program_8
{
    public partial class WinterPic : Form
    {
        public WinterPic()
        {
            InitializeComponent();
        }

        // the drawing and animation all take place on the imagePanel; imagePanel_Paint uses an override
        // of OnPaint. base.OnPaint must be called by the overriding method.

        private void imagePanel_Paint_1(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);    // this call is required

            // This section specifies various pens, brushes, and shapes used in the presentation.

            using (Graphics grafix = this.imagePanel.CreateGraphics())
            {
                Graphics g = e.Graphics;
                SolidBrush shoeBrush = new SolidBrush(Color.Red);
                SolidBrush newBrush = new SolidBrush(Color.Yellow);
                Pen shoePen = new Pen(Color.Black);
                Pen newPen = new Pen(Color.Brown);
                Font shoeFont = new Font("Ariel", 32);
                Font tinyFont = new Font("Ariel", 12);
                Point duHoc = new Point(0, 350); // This point is the anchor point for the upper text.
                Point tief = new Point(119, 490); // This point is the anchor for the lower text.

                g.DrawRectangle(shoePen, 0, 350, 900, 100);

                // I know this is ugly, but the program wouldn't let me split the string... and I didn't
                // want a line wrap.
                g.DrawString
        ("It's said that a rolling stone gathers no moss;\n a rolling snowball, on the other hand..."
        , shoeFont, shoeBrush, duHoc);

                g.FillEllipse(shoeBrush, 110, 470, 220, 65);

                g.DrawString("Press the Start/Stop button!", tinyFont, newBrush, tief);
            }
        }

        //This method starts the animation; the timer_Tick is set to 500 milliseconds.
        //There are 11 cels in the animation.

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            // toggle the timer
            celsTimer.Enabled = !celsTimer.Enabled;

            // change the text of the button
            if (celsTimer.Enabled) { this.startStopBtn.Text = "STOP"; }
            else { this.startStopBtn.Text = "START"; }
        }

        // Calls the animator every 500 milliseconds
        private void celsTimer_Tick(object sender, EventArgs e)
        {
            animator(j);
        }

        int j = 0;

        private void animator(int dex)
        {
            this.imagePanel.Invalidate(); // the Invalidate command invokes OnPaint()

            this.imagePanel.BackgroundImage = celsList.Images[dex];
            if (j < celsList.Images.Count - 1)
            {
                j++;
            }
            else { j = 0; } // the animation will play continuously until someone stops it.
        }
    }
}
