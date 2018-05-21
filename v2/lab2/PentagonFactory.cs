using System;
using System.Collections.Generic;
using Shapes;
namespace factories
{
    internal class PentagonFactory 
    {
        public Pentagon CreatePentagon(Point p, double a)
        {
            return new Pentagon(p, a);
        }
    }
    
}

