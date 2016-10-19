using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    public class Circle : TwoDimensionalShapes //Inherits from TwoDimensionalShapes
    {
        public Point center;
        private double radius;
        public double cylrad;

        // default constructor
        Circle()
        {
            // implicit call to Point constructor
        }

        // constructor
        public Circle(double rvalue, int xvalue, int yvalue, int zvalue = 0)
        {
            center = new Point(xvalue, yvalue, zvalue);
            Radius = rvalue; // from property Radius
        }

        // property Radius
        public double Radius
        {
            get
            {
                return radius;
            }

            set // check for non-negative radius
            {
                if (value >= 0) radius = value; 
            }
        }

        // Calculate the diameter
        public double Diameter()
        {
            return 2 * radius;
        }


        // Calculate the circumference
        public double Circumference()
        {
            return Math.PI * Diameter();
        }

        // Calculate the area
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Return a string representation of the circle
        public override string ToString()
        {
            return " is centered at " + center + "and has a radius of " + radius + ".\n" +
                "Its area is " + Area() + " and its circumference is " + Circumference() + ".\n";
        }

        // Override the Name property from AbstractShape
        public override string Name
        {
            get
            {
                return "Circle";
            }
        }
    }
}
