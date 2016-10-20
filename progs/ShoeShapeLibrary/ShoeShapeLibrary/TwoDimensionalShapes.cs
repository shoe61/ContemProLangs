//      Scott Schumacher
//      10-20-2016
//      FileName: TwoDimensionalShapes.cs
//      This file defines and implements the TwoDimensionalShapes class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    public abstract class TwoDimensionalShapes : AbstractShape //Inherits from AbstractShape
    {
        // All two dimensional shapes have a calculable area
        public virtual double Area()
        {
            return 0;
        }

        // All shapes have a property that describes the length of their
        // outer boundaries; for circles, it's circumference and for squares,
        // it's perimeter.
        public virtual double Perimeter()
        {
            return 0;
        }
    } //ENDO class TwoDimensionalShapes
}
