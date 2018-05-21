using System;
using System.Collections.Generic;
using Shapes;
namespace factories
{
    internal class SquareFactory 
    {
        public Shape CreateSquare(Point p, double a)
        {
            return new Square(p, a);
        }
    }
    
}

