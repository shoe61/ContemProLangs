//      Scott Schumacher
//      10-20-2016
//      FileName: Cylinder.cs
//      This file defines and implements the cylinder class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    public class Cylinder : ThreeDimensionalSolids //Inherits from ThreeDimensionalSolids
    {
        Circle CylBase;
        private double height;

        // default constructor
        Cylinder()
        {
        }

        // constructor
        public Cylinder(double rvalue, int xvalue, int yvalue,  int zvalue, double heightvalue)
        {
            // The base of a cylinder is a circle; an inheritance relationship is not
            // appropriate here, because a cylinder ! "is a" circle, but a cylinder 
            // "has a" circle as one of its defining elements.
            CylBase = new Circle(rvalue, xvalue, yvalue, zvalue); 
            //Radius = rvalue; // from property Radius
            height = heightvalue;
        }

        // calculate the volume of the cylinder
        public override double Volume()
        {
            return CylBase.Area() * height;
        }

        // calculate the surface area of the cylinder
        public override double SurfaceArea()
        {
            return CylBase.Area() * 2 + CylBase.Circumference() * height;
        }

        // Return a string representation of the cylinder
         public override string ToString()
        {
            return " 's base is centered at " + CylBase.center + ". It has a radius of " +
                CylBase.Radius + ".\n" + "Cylinder's height is: " + height + "." + 
                "\n\nIts volume is " + Volume() + " and its surface area is " + 
                SurfaceArea() + ".\n";
        }

        // Override the Name property from AbstractShape
        public override string Name
        {
            get
            {
                return "Cylinder";
            }
        }
    }
}
