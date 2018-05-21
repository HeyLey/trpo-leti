using System;
namespace Lab3
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
            a * b,
            "RECTANGLE")
        { }  
        
        public override void Zoom2x()
        {
            Console.WriteLine(Name + ": My square was " + Square);  
            var c = Math.Sqrt(2);
            Points[1].X = Points[1].X * c; 
            Points[2].Y = Points[2].Y * c; 
            Points[3].X = Points[3].X * c; 
            Points[3].Y = Points[3].Y * c;
            Square = Square * 2;
            Console.WriteLine("My square is now " + Square);             
        }
        
    }
    
}