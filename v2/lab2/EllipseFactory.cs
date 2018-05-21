using System;
using System.Collections.Generic;
using Shapes;
namespace factories
{
    internal class EllipseFactory 
    {
        public Shape CreateEllipse(Point p, double a, double b)
        {
            return new Ellipse(p, a, b);
        }
    }
    
}

