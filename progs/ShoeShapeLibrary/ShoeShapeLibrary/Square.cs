using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    public class Square:TwoDimensionalShapes // Inherits from TwoDimensionalShapes
    {
        Point llhc, lrhc, urhc, ulhc;   // lower left hand corner, lower right hand corner, 
                                        // upper right hand corner, upper left hand corner.
        private int side;

        // default constructor
        Square()
        {
            // implicit call to point constructor
        }

        // constructor: define square by specifying lower left corner and side length
        public Square(int xvalue, int yvalue, int sidevalue) 
        {
            // knowing the coordinates of the lower left and upper right corners, pro-
            // cede counterclockwise from lower left and instantiate the corners
            llhc = new Point(xvalue, yvalue);
            Side = sidevalue;  //using property Side
            lrhc = new Point(xvalue + side, yvalue);
            urhc = new Point(xvalue + side, yvalue + side);
            ulhc = new Point(xvalue, yvalue + side);
        }

        public int Side
        {
            get
            {
                return side;
            }

            set
            {
                // check for validity                
                if (value >= 0) side = value;
            }
        }

        // Calculate the Area
        public override double Area()
        {
            return Math.Pow(side, 2);
        }

        // Calculate the Perimeter
        public override double Perimeter()
        {
            return 4 * side;
        }

        // Return String Representation
        public override string ToString()
        {
            return " has its lower left corner at " + llhc + "its lower right corner at "
                + lrhc + "the upper right corner at " + urhc +
                "and its upper left corner at " + ulhc + ".\n" + "Its area is " + Area() +
                " and its perimeter is " + Perimeter() +".\n";
        }

        // Override the Name property from AbstractShape
        public override string Name
        {
            get
            {
                return "Square";
            }
        }
    }
}
