using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CylinderTest
{
    class Cylinder : Circle4
    {
        private double height;

        public Cylinder()
        {

        }

        public Cylinder(int xValue, int yValue, double radiusValue, double height) : base (xValue, yValue, radiusValue)
        {
            Height = height;
        }

        public double Height
        {
            get { return height;
            }
            set
            {
                if (value >= 0)
                    height = value;
                else height = 0;
            }
        }

        public override double Area()
        {
           return 2* base.Area() + base.Circumference()*Height;
        }

        public virtual double Volume()
        {
            return base.Area() * Height;
        }

        public override string ToString()
        {
            return base.ToString() + "; Height = " + Height;
        }

        public override string Name
        {
            get { return "Cylinder"; }
        }

    }
}
