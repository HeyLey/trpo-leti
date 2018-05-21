using System;

namespace Shapes
 {
     public class Rectangle : Shape, IScalable
     {

         protected Point[] points = new Point[4];
         protected double area;

         public event EventHandler<double> AreaChanged;
         
         public Rectangle(Point lowerLeftPoint, double a, double b) : base("RECTANGLE")
         {
             points[0] = lowerLeftPoint;
             points[1] = new Point(lowerLeftPoint.X + a, lowerLeftPoint.Y);
             points[2] = new Point(lowerLeftPoint.X, lowerLeftPoint.Y + b);
             points[3] = new Point(lowerLeftPoint.X + a, lowerLeftPoint.Y + b);
             area = a * b;

         }   
          
         public override string ToString()
         {
             var str = Name + "\n" + "Points: " + "\n" + points[0] + "\n" + points[1] + "\n" + points[2] + "\n" + points[3] + "\n";
             return str;
         }

         public override double GetArea()
         {
             return area;
         }
         
         public void scale(double c) {
             Console.WriteLine(this + "My area was " + area);    
             var v = Math.Sqrt(c);
             points[0].X = points[0].X * v; 
             points[1].Y = points[2].Y * v; 
             points[2].X = points[3].X * v; 
             points[3].Y = points[3].Y * v;
             area = area * c;
             Console.WriteLine("Now I'm ");

             AreaChanged?.Invoke(this, area);
         }
     }
 }