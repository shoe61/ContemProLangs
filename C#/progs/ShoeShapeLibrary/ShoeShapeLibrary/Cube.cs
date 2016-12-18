//      Scott Schumacher
//      10-20-2016
//      FileName: Cube.cs
//      This file defines and implements the Cube class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    public class Cube: ThreeDimensionalSolids
    {
        Point llhc, lrhc, urhc, ulhc, rllhc, rlrhc, rurhc, rulhc;   
        // lower left hand corner, lower right hand corner, upper right hand corner, 
        // upper left hand corner, rear lower left hand corner, rear lower right 
        // hand corner, rear upper right hand corner, and rear upper left hand corner.

        private int side;

        // default constructor
        Cube()
        {
            // implicit call to Point constructor
        } 

        // constructor
        public Cube(int xvalue, int yvalue,  int zvalue, int sidevalue)
        {
            // knowing the coordinates of the lower left and upper right corners, pro-
            // cede counterclockwise from lower left and instantiate the corners, while
            // similarly instantiating the rear corners
            Side = sidevalue;  //using property Side
            llhc = new Point(xvalue, yvalue, zvalue);
            rllhc = new Point(xvalue, yvalue, zvalue - side);
            lrhc = new Point(xvalue + side, yvalue, zvalue);
            rlrhc = new Point(xvalue + side, yvalue, zvalue - side);
            urhc = new Point(xvalue + side, yvalue + side, zvalue);
            rurhc = new Point(xvalue + side, yvalue + side, zvalue - side);
            ulhc = new Point(xvalue, yvalue + side, zvalue);
            rulhc = new Point(xvalue, yvalue + side, zvalue - side);
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

        // calclate the surface area
        public override double SurfaceArea()
        {
            return Math.Pow(side, 2) * 6;
        }

        // calculate the volume
        public override double Volume()
        {
            return Math.Pow(side, 3);
        }

        // Return String Representation
        public override string ToString()
        {
            return " has its lower left corner at " + llhc + ", its lower right corner at "
                + lrhc + "," + "\nthe upper right corner at " + urhc +
                ", and its upper left corner at " + ulhc + ".\n\n" + "The rear corners are: " +
                "lower left: " + rllhc + ", lower right: " + rlrhc +",\n" + "upper right: " + 
                rurhc + ", and upper left: " + rulhc + "." + "\n\nIts surface area is " + 
                SurfaceArea() + " and its volume is " + Volume() + ".\n";
        }
        
        // Override the Name property from AbstractShape
        public override string Name
        {
            get
            {
                return "Cube";
            }
        }
       
    }
}
