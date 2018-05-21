using System;

namespace Lab1
{
    public  abstract class Shape : IShape
    {
        private readonly Point[] Points;
        private string Color { get; set; }
        protected string Name { get; set; }

        protected Shape(string color, Point[] points, string name)
        {
            Color = color;
            Points = points;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Points:");
            foreach (var p in Points)
            {
                Console.WriteLine(p + " ");
            }
            Console.WriteLine("\n");
        }

        // a in grads
        public void Rotate(double a)
        {
            foreach (var p in Points)
            {
                RotatePoint(p, a);
            }
        }

        // a in grads
        private static void RotatePoint(Point p, double a)
        {
            p.X = p.X * Math.Cos(a) - p.Y * Math.Sin(a);
            p.Y = p.X * Math.Sin(a) + p.Y * Math.Cos(a);
        }

        public void Transfer(double x, double y)
        {
            for (var i = 0; i < Points.Length; i++)
            {
                var p = Points[i];
                Points[i] = new Point(p.X + x, p.Y + y);
            }
        }
    }
}