using System.Dynamic;

namespace Shapes
 {
     public class Rectangle 
     {
         protected string Name = "RECTANGLE";

         protected Point[] points = new Point[4];

         public Rectangle(Point lowerLeftPoint, double a, double b)
         {
             points[0] = lowerLeftPoint;
             points[1] = new Point(lowerLeftPoint.X + a, lowerLeftPoint.Y);
             points[2] = new Point(lowerLeftPoint.X, lowerLeftPoint.Y + b);
             points[3] = new Point(lowerLeftPoint.X + a, lowerLeftPoint.Y + b);

         }   
          
         public override string ToString()
         {
             var str = Name + "\n" + "Points: " + "\n" + points[0] + "\n" + points[1] + "\n" + points[2] + "\n" + points[3] + "\n";
             return str;
         } 
     }
 }