using System;
using Shapes;

namespace Shapes
{
    public class Pentagon : Shape
    {
        private Point[] points = new Point[5];
        private double a;

        public Pentagon(Point upperLeftPoint, double a) : base ("PENTAGON")
        {
            points[0] = upperLeftPoint;
            points[1] = new Point(upperLeftPoint.X + a, upperLeftPoint.Y);
            points[2] = new Point(upperLeftPoint.X - Math.Sin(18 * Math.PI / 180) * a,
                upperLeftPoint.Y - Math.Cos(18 * Math.PI / 180) * a);
            points[3] = new Point(upperLeftPoint.X + a + Math.Sin(18 * Math.PI / 180) * a,
                upperLeftPoint.Y - Math.Cos(18 * Math.PI / 180) * a);
            points[4] = new Point(upperLeftPoint.X + a / 2,
                upperLeftPoint.Y - (Math.Cos(18 * Math.PI / 180) + Math.Sin(72 * Math.PI / 180)) * a);
            this.a = a;

        }
        
        public override string ToString()
        {
            var str = Name + "\n" + "Points: " + "\n" + points[0] + "\n" + points[1] + "\n" + points[2] + "\n" + points[3] + "\n" + points[4] + "\n";
            return str;
        }

        public override double GetArea()
        {
            return a * a * Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4;
        }
    }
}