using System;

namespace Shapes
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            var s = "(" + Math.Round(X, 5) + ", " + Math.Round(Y, 5) + ")";
            return s;
        }
    }
}