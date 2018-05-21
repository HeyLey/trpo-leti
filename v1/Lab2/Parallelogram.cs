using System;

namespace Lab2
{
    public class Parallelogram : Shape
    {
        internal Parallelogram(string color, Point lowerLeftPoint, double a, double b, double ang) : base(color, 
            new[] {
                lowerLeftPoint,
                new Point(lowerLeftPoint.X + a, lowerLeftPoint.Y),    
                new Point(lowerLeftPoint.X + Math.Cos(ang) * b, lowerLeftPoint.Y + Math.Sin(ang) * b),
                new Point(lowerLeftPoint.X + Math.Cos(ang) * b + a, lowerLeftPoint.Y + Math.Sin(ang) * b) 
            },
            a * b * Math.Sin(ang), "PARALLELOGRAM")
        { }   
    }
}