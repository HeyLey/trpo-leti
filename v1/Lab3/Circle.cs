using System;

namespace Lab3
{
    public class Circle : Ellipse
    {

        internal Circle(string color, Point center, double r1) : base(color, center, r1, r1)
        {
            Name = "CIRCLE";
        }
 
        public override void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Center: " + Points[0]);
            Console.WriteLine("Radius: " + r1);
            Console.WriteLine("\n");
        }

    }
}