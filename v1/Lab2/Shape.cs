using System;

namespace Lab2
{
    public abstract class Shape
    {
        protected readonly Point[] Points;
        protected string Name { get; set; }
        private string Color { get; set; }
        private double Square{ get; set; }

        protected Shape(string color, Point[] points, double square, string name)
        {
            Color = color;
            Points = points;
            Square = square;
            Name = name;
        }

        public virtual void Print()
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

        public double GetSquare()
        {
            return Square;
        }
    }
}