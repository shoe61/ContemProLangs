using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphismTest
{
    public partial class PolymorphismTestForm : Form
    {
        public PolymorphismTestForm()
        {
            InitializeComponent();

            Point point1 = new Point(30, 50);
            Circle circle1 = new Circle(120, 89, 2.7);

            string output = "Point point1: " + point1.ToString() +
               "\nCircle circle1: " + circle1.ToString();

            // use 'is a' relationship to assign 
            // Circle circle1 to Point reference
            Point point2 = circle1;

            output += "\n\nCCircle circle1 (via point2): " +
               point2.ToString();

            // downcast (cast base-class reference to derived-class
            // data object type) point2 to Circle circle2
            Circle circle2 = (Circle)point2;

            output += "\n\nCircle circle1 (via circle2): " +
               circle2.ToString();

            output += "\nArea of circle1 (via circle2): " +
               circle2.Area().ToString("F");

            // attempt to assign point1 object to Circle reference
            if (point1 is Circle)
            {
                circle2 = (Circle)point1;
                output += "\n\ncast successful";
            }
            else
            {
                output += "\n\npoint1 does not refer to a Circle";
            }


            MessageBox.Show(output,
               "Demonstrating the 'is a' relationship");



        }
    }
}
