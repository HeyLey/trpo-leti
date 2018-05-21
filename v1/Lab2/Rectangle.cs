using System;

namespace Lab2
{
    public class Rectangle : Parallelogram
    {
        internal Rectangle(string color, Point lowerLeftPoint, double a, double b) : base(color, lowerLeftPoint, a, b, Math.PI / 2)
        {
            Name = "RECTANGLE";
        }   
    }
}