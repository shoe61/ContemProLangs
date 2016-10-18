using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CircleTest4
{
    public partial class CircleTest4Form : Form
    {
        public CircleTest4Form()
        {
            InitializeComponent();
        }

        private void CircleTest4Form_Load(object sender, EventArgs e)
        {
            // instantiate Circle4
            Circle4 circle = new Circle4(37, 43, 2.5);

            // get Circle4's initial x-y coordinates and radius
            string output = "X coordinate is " + circle.X + "\n" +
               "Y coordinate is " + circle.Y + "\n" +
               "Radius is " + circle.Radius;

            // set Circle4's x-y coordinates and radius to new values
            circle.X = 2;
            circle.Y = 2;
            circle.Radius = 4.25;

            // display Circle4's String representation
            output += "\n\n" +
               "The new location and radius of circle are " +
               "\n" + circle + "\n";

            // display Circle4's Diameter
            output += "Diameter is " +
               String.Format("{0:F}", circle.Diameter()) + "\n";

            // display Circle4's Circumference
            output += "Circumference is " +
               String.Format("{0:F}", circle.Circumference()) + "\n";

            // display Circle4's Area
            output += "Area is " +
               String.Format("{0:F}", circle.Area());

            displayLabel.Text = output;

            }
    }
}
