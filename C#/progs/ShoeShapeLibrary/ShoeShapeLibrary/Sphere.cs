//      Scott Schumacher
//      10-20-2016
//      FileName: Sphere.cs
//      This file defines and implements the Sphere class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    public class Sphere : ThreeDimensionalSolids //Inherits from ThreeDimensionalSolids
    {
        Point center;
        private double radius;

        // default constructor
        Sphere()
        {
            // implicit call to Point constructor
        }

        // constructor
        public Sphere(int xvalue, int yvalue, int zvalue, double rvalue)
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

        // Calculate the volume
        public override double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3);
        }

        // Return a string representation of the circle
        public override string ToString()
        {
            return " is centered at" + center + " and has a radius of " + radius + 
                ".\n\n " + "Its volume is " + Volume() + ".";
        }

        // Override the Name property from AbstractShape
        public override string Name
        {
            get
            {
                return "Sphere";
            }
        }
    }//ENDO class Sphere
}
