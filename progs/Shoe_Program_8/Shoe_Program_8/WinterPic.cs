using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Program_8
{
    public partial class WinterPic : Form
    {
        public WinterPic()
        {
            InitializeComponent();
        }

        private void imagePanel_Paint_1(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics grafix = this.imagePanel.CreateGraphics())
            {
                Graphics g = e.Graphics;
                SolidBrush shoeBrush = new SolidBrush(Color.Red);
                SolidBrush newBrush = new SolidBrush(Color.Black);
                Pen shoePen = new Pen(Color.Black);
                Pen newPen = new Pen(Color.Brown);
                Font shoeFont = new Font("Ariel", 32);
                Font tinyFont = new Font("Ariel", 12);
                Point duHoc = new Point(0, 350);
                Point tief = new Point(126, 490);

                g.DrawRectangle(shoePen, 0, 350, 900, 100);

                g.DrawString("It's said that a rolling stone gathers no moss;\n A rolling snowball on the other hand..",
                    shoeFont, shoeBrush, duHoc);

                g.DrawEllipse(newPen, 110, 470, 200, 65);

                g.DrawString("Press the Start button!", tinyFont, newBrush, tief);
            }
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            // toggle the timer
            celsTimer.Enabled = !celsTimer.Enabled;

            // change the text of the button
            if (celsTimer.Enabled) { this.startStopBtn.Text = "STOP"; }
            else { this.startStopBtn.Text = "START";}
        }

        private void celsTimer_Tick(object sender, EventArgs e)
        {
            animator(j); 
        }

        int j = 0;

        private void animator(int dex)
        {
            
            this.imagePanel.Invalidate();
            
            this.imagePanel.BackgroundImage = celsList.Images[dex];
            if(j < celsList.Images.Count - 1)
            {
                j++;
            }
            else { j = 0; }
        }


       
    }
}
