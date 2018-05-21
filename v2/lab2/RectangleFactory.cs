using System;
using System.Collections.Generic;
using Shapes;
namespace factories
{
    internal class RectangleFactory 
    {
        public Shape CreateRectangle(Point p, double a, double b)
        {
            return new Rectangle(p, a, b);
        }
    }
    
}

