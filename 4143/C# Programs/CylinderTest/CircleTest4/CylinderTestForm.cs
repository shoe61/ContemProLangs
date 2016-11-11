using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CylinderTest
{
    public partial class CylinderTestForm : Form
    {
        public CylinderTestForm()
        {
            InitializeComponent();
        }

        private void CylinderTestForm_Load(object sender, EventArgs e)
        {
            // instantiate Cylinder
            Cylinder cylinder = new Cylinder (37, 43, 2.5, 5.0);

            // get Cylinder's initial x-y coordinates, radius and height
            string output = "X coordinate is " + cylinder.X + "\n" +
               "Y coordinate is " + cylinder.Y + "\n" +
               "Radius is " + cylinder.Radius  + "\nHeight is " + cylinder.Height;

            // set Cylinder's x-y coordinates and radius to new values
            cylinder.X = 2;
            cylinder.Y = 2;
            cylinder.Radius = 4.25;

            // display Cylinder's String representation
            output += "\n\n" +
               "The new location and radius of cylinder are " +
               "\n" + cylinder + "\n";

            // display Cylinder's Diameter
            output += "Diameter is " +
               String.Format("{0:F}", cylinder.Diameter()) + "\n";

            // display Cylinder's Circumference
            output += "Circumference is " +
               String.Format("{0:F}", cylinder.Circumference()) + "\n";

            // display Cylinder's Area
            output += "Area is " +
               String.Format("{0:F}", cylinder.Area());

            displayLabel.Text = output;

            }
    }
}
