//      Scott Schumacher
//      10-20-2016
//      FileName: DisplayShapes.cs
//      This program invites the user to select two- or three-dimensional shapes
//      to display; It also provides a string description of each shape.


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
            // Clicking the Circle button makes all other shape buttons
            // and the unnecessary controls invisible.
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
            // Clicking the Square button makes all other shape buttons
            // and the unnecessary controls invisible.
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
            // Clicking the Rectangle button makes all other shape buttons
            // and the unnecessary controls invisible.
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
            // Clicking the Sphere button makes all other shape buttons
            // and the unnecessary controls invisible.
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
            // Clicking the Cube button makes all other shape buttons
            // and the unnecessary controls invisible.
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
            // Clicking the Cylinder button makes all other shape buttons
            // and the unnecessary controls invisible.
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
            // The Draw Button's actions depend on which controls are visible;
            // If a user clicks the Draw Button without having supplied all the 
            // required information, an exception is thrown and the user is ad-
            // vised through a MessageBox to observe the correct sequence.
            try
            {
                if (CircleButton.Visible) //instantiate and display a circle
                {
                    Circle bob = new Circle(double.Parse(radiusTxtBx.Text), 
                        int.Parse(xTextBox.Text), int.Parse(yTextBx.Text), 0);
                    string output = bob.Name + " " + bob;
                    ShapePictureBx.ImageLocation = "circle.png";
                    DescriptionLabel.Text = output;
                }

                if (SquareButton.Visible) //instantiate and display a square
                {
                    Square lucy = new Square(int.Parse(xTextBox.Text), 
                        int.Parse(yTextBx.Text), int.Parse(sideTxtBx.Text));
                    string output = lucy.Name + " " + lucy + "\n";
                    ShapePictureBx.ImageLocation = "square.png";
                    DescriptionLabel.Text = output;
                }

                if (RectangleButton.Visible) //instantiate and display a rectangle
                {
                    SRectangle fred = new SRectangle(int.Parse(xTextBox.Text), 
                        int.Parse(yTextBx.Text), int.Parse(lengthTxtBx.Text), 
                        int.Parse(widthTxtBx.Text));
                    string output = fred.Name + " " + fred + "\n";
                    ShapePictureBx.ImageLocation = "rectangle.png";
                    DescriptionLabel.Text = output;
                }

                if (SphereButton.Visible) //instantiate and display a sphere
                {
                    Sphere heather = new Sphere(int.Parse(xTextBox.Text), 
                        int.Parse(yTextBx.Text), int.Parse(zTextBx.Text), 
                        double.Parse(radiusTxtBx.Text));
                    string output = heather.Name + " " + heather + "\n";
                    ShapePictureBx.ImageLocation = "sphere.png";
                    DescriptionLabel.Text = output;
                }

                if (CubeButton.Visible) //instantiate and display a cube
                {
                    Cube newton = new Cube(int.Parse(xTextBox.Text), int.Parse(yTextBx.Text),
                        int.Parse(zTextBx.Text), int.Parse(sideTxtBx.Text));
                    string output = newton.Name + " " + newton + "\n";
                    ShapePictureBx.ImageLocation = "cube.png";
                    DescriptionLabel.Text = output;
                }

                if (CylinderButton.Visible) //instantiate and display a cylinder
                {
                    Cylinder felix = new Cylinder(double.Parse(radiusTxtBx.Text), 
                        int.Parse(xTextBox.Text), int.Parse(yTextBx.Text), 
                        int.Parse(zTextBx.Text), double.Parse(heightTxtBx.Text));
                    string output = felix.Name + " " + felix + "\n";
                    ShapePictureBx.ImageLocation = "cylinder.png";
                    DescriptionLabel.Text = output;
                }

                
            }

            catch(Exception ex) // display the system message and specific instructions
            {
                MessageBox.Show(ex.Message + " Please select a shape  and enter " 
                + "the required data before clicking the Draw button.");
            }
            

        }

        // The TryAgainButton resets all the controls to visible and erases
        // all data.
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
            xTextBox.Text = "";
            yTextBx.Text = "";
            zTextBx.Text = "";
            radiusTxtBx.Text = "";
            sideTxtBx.Text = "";
            lengthTxtBx.Text = "";
            widthTxtBx.Text = "";
            heightTxtBx.Text = "";
            ShapePictureBx.Image = null;
            DescriptionLabel.Text = null;
        }

        


    }
}
