using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeShapeLibrary;

namespace shapeTester
{
    class Program
    {
        static void Main(string[] args)
        {

            Point zorg = new Point(2, 3, 5);
            Circle bob = new Circle(4,2,2,0);
            Square sally = new Square(3, 3, 5);
            Rectangle stan = new Rectangle(4, 4, 10, 5);
            Cylinder felix = new Cylinder(4.5, 8, 3, 7, 10);
            AbstractShape shozape;

            shozape = bob;

            string output = zorg.Name + " " + zorg + "\n" +
            bob.Name + " " + bob + "\n" +
            sally.Name + " " + sally + "\n" +
            stan.Name + " " + stan + "\n" +

            felix.Name + " " + felix + "\n";

            MessageBox.Show(output);
        }
    }
}
