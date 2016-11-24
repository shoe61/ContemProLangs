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


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics grafix = this.imagePanel.CreateGraphics())
            {
                SolidBrush shoeBrush = new SolidBrush(Color.Red);
                Pen shoePen = new Pen(Color.Black);
                Font shoeFont = new Font("Ariel", 32);

                grafix.DrawString("First, the required elements.", shoeFont, shoeBrush, 25, 25);
                grafix.DrawString("Rectangles, drawn and filled:", shoeFont, shoeBrush, 25, 100);
                grafix.DrawString("Ellipses, drawn and filled: ", shoeFont, shoeBrush, 25, 200);
                grafix.DrawString("Now I have a problem, because I'm no artist, and Texas has ", shoeFont, shoeBrush, 25, 300);
                grafix.DrawString("no winter to speak of... ", shoeFont, shoeBrush, 25, 400);
                
                grafix.DrawRectangle(shoePen, 600, 100, 200, 50);
                grafix.FillRectangle(shoeBrush, 900, 100, 200, 50);

                grafix.DrawEllipse(shoePen, 600, 200, 200, 50);
                grafix.FillEllipse(shoeBrush, 900, 200, 200, 50);

                

                Point a = new Point(0,400);
                Point b = new Point(1000, 800);
                Point c = new Point(0, 800);
                Point d = new Point(1000, 400);

                Point[] hillPoints = {a, b, c, d};

                //grafix.DrawPolygon(shoePen, hillPoints);
                //grafix.DrawLines(shoePen, hillPoints);
            }
        }



       
    }
}
