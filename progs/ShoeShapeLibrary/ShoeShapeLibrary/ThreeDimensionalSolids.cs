//      Scott Schumacher
//      10-20-2016
//      FileName: ThreeDimensionalSolids.cs
//      This file defines and implements the ThreeDimensionalSolids class.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    public abstract class ThreeDimensionalSolids : AbstractShape // Inherits from AbstractShape
    {
        // Solids: spheres, cubes, cylinders all have calculable volumes
        public virtual double Volume()
        {
            return 0;
        }

        // All solids have calculable surface areas
        public virtual double SurfaceArea()
        {
            return 0;
        }
    } //ENDO class ThreeDimensionalSolids
}
