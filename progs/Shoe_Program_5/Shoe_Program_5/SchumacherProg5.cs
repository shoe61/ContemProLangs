using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeShapeLibrary;

namespace Shoe_Program_5
{
    public partial class ScottSchumacher_Prog_5 : Form
    {
        public ScottSchumacher_Prog_5()
        {
          InitializeComponent();

        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            sideLabel.Visible = false;
            sideTxtBx.Visible = false;
            widthLabel.Visible = false;
            widthTxtBx.Visible = false;
            lengthLabel.Visible = false;
            widthTxtBx.Visible = false;
            lengthLabel.Visible = false;
            lengthTxtBx.Visible = false;
            heightLabel.Visible = false;
            heightTxtBx.Visible = false;
            zLabel.Visible = false;
            zTextBx.Visible = false;
            SquareButton.Visible = false;
            RectangleButton.Visible = false;
            SphereButton.Visible = false;
            CubeButton.Visible = false;
            CylinderButton.Visible = false;
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            radiusLabel.Visible = false;
            radiusTxtBx.Visible = false;
            widthLabel.Visible = false;
            widthTxtBx.Visible = false;
            lengthLabel.Visible = false;
            lengthTxtBx.Visible = false;
            heightLabel.Visible = false;
            heightTxtBx.Visible = false;
            zLabel.Visible = false;
            zTextBx.Visible = false;
            CircleButton.Visible = false;
            RectangleButton.Visible = false;
            SphereButton.Visible = false;
            CubeButton.Visible = false;
            CylinderButton.Visible = false;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            radiusLabel.Visible = false;
            radiusTxtBx.Visible = false;
            sideLabel.Visible = false;
            sideTxtBx.Visible = false;
            heightLabel.Visible = false;
            heightTxtBx.Visible = false;
            zLabel.Visible = false;
            zTextBx.Visible = false;
            CircleButton.Visible = false;
            SquareButton.Visible = false;
            SphereButton.Visible = false;
            CubeButton.Visible = false;
            CylinderButton.Visible = false;
        }

        private void SphereButton_Click(object sender, EventArgs e)
        {
            sideLabel.Visible = false;
            sideTxtBx.Visible = false;
            widthLabel.Visible = false;
            widthTxtBx.Visible = false;
            lengthLabel.Visible = false;
            widthTxtBx.Visible = false;
            lengthLabel.Visible = false;
            lengthTxtBx.Visible = false;
            heightLabel.Visible = false;
            heightTxtBx.Visible = false;
            CircleButton.Visible = false;
            SquareButton.Visible = false;
            RectangleButton.Visible = false;
            CubeButton.Visible = false;
            CylinderButton.Visible = false;
        }

        private void CubeButton_Click(object sender, EventArgs e)
        {
            radiusLabel.Visible = false;
            radiusTxtBx.Visible = false;
            widthLabel.Visible = false;
            widthTxtBx.Visible = false;
            lengthLabel.Visible = false;
            lengthTxtBx.Visible = false;
            heightLabel.Visible = false;
            heightTxtBx.Visible = false;
            CircleButton.Visible = false;
            SquareButton.Visible = false;
            RectangleButton.Visible = false;
            SphereButton.Visible = false;
            CylinderButton.Visible = false;
        }

        private void CylinderButton_Click(object sender, EventArgs e)
        {
            sideLabel.Visible = false;
            sideTxtBx.Visible = false;
            widthLabel.Visible = false;
            widthTxtBx.Visible = false;
            lengthLabel.Visible = false;
            widthTxtBx.Visible = false;
            lengthLabel.Visible = false;
            lengthTxtBx.Visible = false;
            CircleButton.Visible = false;
            SquareButton.Visible = false;
            RectangleButton.Visible = false;
            SphereButton.Visible = false;
            CubeButton.Visible = false;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if(CircleButton.Visible)
            {
                Circle bob = new Circle(double.Parse(radiusTxtBx.Text), int.Parse(xTextBox.Text), int.Parse(yTextBx.Text), 0);
                string output = bob.Name + " " + bob + "\n";
                MessageBox.Show(output);
            }

            if(SquareButton.Visible)
            {
                Square lucy = new Square(int.Parse(xTextBox.Text), int.Parse(yTextBx.Text), int.Parse(sideTxtBx.Text));
                string output = lucy.Name + " " + lucy + "\n";
                MessageBox.Show(output);
            }

            if(RectangleButton.Visible)
            {
                SRectangle fred = new SRectangle(int.Parse(xTextBox.Text), int.Parse(yTextBx.Text), int.Parse(lengthTxtBx.Text), int.Parse(widthTxtBx.Text));
                string output = fred.Name + " " + fred + "\n";
                MessageBox.Show(output);
            }

            if(SphereButton.Visible)
            {
                Sphere heather = new Sphere(int.Parse(xTextBox.Text), int.Parse(yTextBx.Text), int.Parse(zTextBx.Text), double.Parse(radiusTxtBx.Text));
                string output = heather.Name + " " + heather + "\n";
                MessageBox.Show(output);
            }

            if(CubeButton.Visible)
            {
                //pass
            }

            if(CylinderButton.Visible)
            {
                Cylinder felix = new Cylinder(double.Parse(radiusTxtBx.Text), int.Parse(xTextBox.Text), int.Parse(yTextBx.Text), int.Parse(zTextBx.Text), double.Parse(heightTxtBx.Text));
                string output = felix.Name + " " + felix + "\n";
                MessageBox.Show(output);
            }

        }

        private void TryAgainButton_Click(object sender, EventArgs e)
        {
            radiusLabel.Visible = true;
            radiusTxtBx.Visible = true;
            sideLabel.Visible = true;
            sideTxtBx.Visible = true;
            widthLabel.Visible = true;
            widthTxtBx.Visible = true;
            lengthLabel.Visible = true;
            widthTxtBx.Visible = true;
            lengthLabel.Visible = true;
            lengthTxtBx.Visible = true;
            heightLabel.Visible = true;
            heightTxtBx.Visible = true;
            zLabel.Visible = true;
            zTextBx.Visible = true;
            CircleButton.Visible = true;
            SquareButton.Visible = true;
            RectangleButton.Visible = true;
            SphereButton.Visible = true;
            CubeButton.Visible = true;
            CylinderButton.Visible = true;
        }

        


    }
}
