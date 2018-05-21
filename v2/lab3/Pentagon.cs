using System;
using Shapes;

namespace Shapes
{
    public class Pentagon : Shape, IScalable
    {
        private Point[] points = new Point[5];
        private double area;
        private double a;

        public event EventHandler<double> AreaChanged;
        
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
            area = a * a * Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4;
            this.a = a;
        }
        
        public override string ToString()
        {
            var str = Name + "\n" + "Points: " + "\n" + points[0] + "\n" + points[1] + "\n" + points[2] + "\n" + points[3] + "\n" + points[4] + "\n";
            return str;
        }

        public override double GetArea()
        {
            return area;
        }
        
        public void scale(double c) {
            Console.WriteLine(this + "My area was " + area);              
            area = area * c;
            a = Math.Sqrt(area / (Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4));
            points[1] = new Point(points[0].X + a, points[0].Y);
            points[2] = new Point(points[0].X - Math.Sin(18 * Math.PI / 180) * a,
                points[0].Y - Math.Cos(18 * Math.PI / 180) * a);
            points[3] = new Point(points[0].X + a + Math.Sin(18 * Math.PI / 180) * a,
                points[0].Y - Math.Cos(18 * Math.PI / 180) * a);
            points[4] = new Point(points[0].X + a / 2,
                points[0].Y - (Math.Cos(18 * Math.PI / 180) + Math.Sin(72 * Math.PI / 180)) * a);
            Console.WriteLine("Now I'm "); 
             
            if (AreaChanged != null)
                AreaChanged(this, area);
        }
    }
}