using System;

namespace Shapes
{
    public class Ellipse : Shape, IScalable
    {
        protected Point center;
        protected  double r1;
        private double r2;
        protected double area;
    
        public event EventHandler<double> AreaChanged;
        
        public Ellipse(Point p, double r1, double r2) : base ("ELLIPSE")
        {
            center = p; 
            this.r1 = r1;
            this.r2 = r2;
            area = r1 * r2 * Math.PI;
        }

        public override string ToString()
        {
            var str = Name + "\n" + "Center: " + center + "\n" + "Radius 1: " + r1 + "\n" + "Radius 2 :" + r2 + "\n";
            return str;
        }

        public override double GetArea()
        {
            return area;
        }
        
        public void scale(double c)
        {
            Console.WriteLine(this + "My area was " + area);  
            var v = Math.Sqrt(c);
            r1 = r1 * v;
            r2 = r2 * v;
            area = r1 * r2 * Math.PI;
            Console.WriteLine("Now I'm "); 
            
            if (AreaChanged != null)
                AreaChanged(this, area);
        }

    }
}
