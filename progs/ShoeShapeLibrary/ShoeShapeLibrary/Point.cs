using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    public class Point 
    {
        // Both two- and three-dimensional Shapes will instantiate Points.
        // For 2-D shapes,  int z will be 0.
        private int x, y, z;

        string name;

        // default constructor
        public Point()
        {
            // implicit call to Object constructor
        }

        // parameterized constructor: zvalue set to zero for two
        // dimensional points
        public Point(int xvalue, int yvalue, int zvalue = 0)
        {
            x = xvalue;
            y = yvalue;
            z = zvalue;
        }

        // property X
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value; // no validation
            }
        }

        // property Y
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value; // no validation
            }
        }

        // property Z
        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value; // no validation
            }
        }

        // Return a string representation of the Point:
        public override string ToString()
        {
            return " (" + X + ", " + Y + ", " + Z + ")";
        }

        // Implement the abstract property Name inherited from AbstractShape:
        public string Name
        {
            get
            {
                return "Point";
            }
        }

    }   // ENDO Class Point
}
