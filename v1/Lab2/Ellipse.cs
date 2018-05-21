using System;

namespace Lab2
{
    public class Ellipse : Shape
    {
        protected readonly double r1;
        private readonly double r2;

        internal Ellipse(string color, Point center, double r1, double r2) : base(color, new []{center}, r1 * r2 * Math.PI, "ELLIPSE")
        {
            this.r1 = r1;
            this.r2 = r2;
        }

        public override void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Center: " + Points[0]);
            Console.WriteLine("Radius 1: " + r1);
            Console.WriteLine("Radius 2 :" + r2);
            Console.WriteLine("\n");
        }
    }
}