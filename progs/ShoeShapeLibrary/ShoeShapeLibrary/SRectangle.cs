using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    public class SRectangle : TwoDimensionalShapes // Inherits from TwoDimensionalShapes
    {
        Point llhc, lrhc, urhc, ulhc;   // lower left hand corner, lower right hand corner, 
        // upper right hand corner, upper left hand corner.
        private int length, width;
        string namu;

        // default constructor
        SRectangle()
        {
            // implicit call to point constructor
        }

        // constructor: define square by specifying lower left corner and side length
        public SRectangle(int xvalue, int yvalue, int lengthvalue, int widthvalue)
        {
            // knowing the coordinates of the lower left corner, pro-
            // cede counterclockwise from lower left and instantiate the corners
            llhc = new Point(xvalue, yvalue);
            Length = lengthvalue;   // using property Side
            Width = widthvalue;     // using property Width
            lrhc = new Point(xvalue + length, yvalue);
            urhc = new Point(xvalue + length, yvalue + width);
            ulhc = new Point(xvalue, yvalue + width);
        }

        // property Length
        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                // check for validity                
                if (value >= 0) length = value;
            }
        }

        // property Width
        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                // check for validity                
                if (value >= 0) width = value;
            }
        }

        // Calculate the Area
        public override double Area()
        {
            return length * width;
        }

        // Calculate the Perimeter
        public override double Perimeter()
        {
            return 2 * (length + width);
        }

        // Return String Representation
        public override string ToString()
        {
            return " has its lower left corner at " + llhc + ", its lower right corner at "
                + lrhc + ", the upper right corner at " + urhc +
                ", and its upper left corner at " + ulhc + ".\n" + "Its area is " + Area() +
                " and its perimeter is " + Perimeter() + ".\n";
        }

        // Override the Name property from AbstractShape
        public override string Name
        {
            get
            {
                return "Rectangle";
            }
        }
    }
}
