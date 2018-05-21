using System;

namespace Lab3
{
    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public static double Dist(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public override string ToString()
        {
            var s = "(" + Math.Round(X, 5) + ", " + Math.Round(Y, 5) + ")";
            return s;
        }
    }
}