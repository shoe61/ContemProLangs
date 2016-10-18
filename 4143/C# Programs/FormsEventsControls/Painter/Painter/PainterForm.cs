using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form
    {
        private bool shouldPaint = false;

        public PainterForm()
        {
            InitializeComponent();
        }

        private void PainterForm_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void PainterForm_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void PainterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(
                new SolidBrush(Color.BlueViolet),
                e.X, e.Y, 4, 4);
            }

        }
    }
}
