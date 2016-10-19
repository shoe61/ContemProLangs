using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShapeLibrary
{
    // AbstractShape is the base class; all other classes inherit from it. 
    // It includes only properties and methods that are applicable to all
    // potential derived classes.
    public abstract class AbstractShape
    {
        // Every shape has a name. Property Name will, through a getter, 
        // provide the name of the shape.
        public abstract string Name
        {
            get;
        }

        // Every shape has a description, which will be output as a string.
        public override string ToString()
        {
            return base.ToString();
        }
    } // ENDO class AbstractShape
}
