namespace Lab1
 {
     public class Rectangle : Shape
     {
         public Rectangle(string color, Point lowerLeftPoint, double a, double b) : base(color, 
             new[] {
                 lowerLeftPoint,
                 new Point(lowerLeftPoint.X + a, lowerLeftPoint.Y),    
                 new Point(lowerLeftPoint.X, lowerLeftPoint.Y + b),
                 new Point(lowerLeftPoint.X + a, lowerLeftPoint.Y + b) 
             },
             "RECTANGLE")
         { }   
  
     }
 }