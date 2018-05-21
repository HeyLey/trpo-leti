using System;

namespace Shapes
{
    public class Ellipse : Shape
    {
        protected Point center;
        protected  double r1;
        private double r2;
    

        public Ellipse(Point p, double r1, double r2) : base ("ELLIPSE")
        {
            center = p; 
            this.r1 = r1;
            this.r2 = r2;
        }

        public override string ToString()
        {
            var str = Name + "\n" + "Center: " + center + "\n" + "Radius 1: " + r1 + "\n" + "Radius 2 :" + r2 + "\n";
            return str;
        }

        public override double GetArea()
        {
            return r1 * r2 * Math.PI;
        }

    }
}
