using System;

namespace Lab3
{
    public class Ellipse : Shape
    {
        protected double r1;
        private double r2;

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
        
        public override void Zoom2x()
        {
            Console.WriteLine(Name + ": My square was " + Square);  
            var c = Math.Sqrt(2);
            r1 = r1 * c;
            r2 = r2 * c;
            Square = r1 * r2 * Math.PI;
            Console.WriteLine("My square is now " + Square);             
        }

    }
    
}