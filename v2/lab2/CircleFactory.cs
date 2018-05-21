using System;
using System.Collections.Generic;
using Shapes;
namespace factories
{
    internal class CircleFactory 
    {
        public Shape CreateCircle(Point p, double a)
        {
            return new Circle(p, a);
        }
    }
    
}

