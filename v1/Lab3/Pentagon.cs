using System;

namespace Lab3
{

    public class Pentagon : Shape
    {
         internal Pentagon(string color, Point upperLeftPoint, double a) : base(color, 
             new[] {
             upperLeftPoint,
             new Point(upperLeftPoint.X + a, upperLeftPoint.Y),       
             new Point(upperLeftPoint.X - Math.Sin(18*Math.PI/180)*a, upperLeftPoint.Y - Math.Cos(18*Math.PI/180)*a),
             new Point(upperLeftPoint.X + a + Math.Sin(18*Math.PI/180)*a, upperLeftPoint.Y - Math.Cos(18*Math.PI/180)*a),
             new Point(upperLeftPoint.X + a/2, upperLeftPoint.Y - (Math.Cos(18*Math.PI/180) + Math.Sin(72*Math.PI/180))*a)   
             }, a * a * Math.Sqrt(25 + 10 * Math.Sqrt(5))/4, "PENTAGON")
         {  }
        
         public override void Zoom2x()
         {
             Console.WriteLine(Name + ": My square was " + Square);  
             Square = Square * 2;
             var a = Math.Sqrt(Square / (Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4));
             Points[1] = new Point(Points[0].X + a, Points[0].Y);
             Points[2] = new Point(Points[0].X - Math.Sin(18 * Math.PI / 180) * a,
             Points[0].Y - Math.Cos(18 * Math.PI / 180) * a);
             Points[3] = new Point(Points[0].X + a + Math.Sin(18 * Math.PI / 180) * a,
             Points[0].Y - Math.Cos(18 * Math.PI / 180) * a);
             Points[4] = new Point(Points[0].X + a / 2,
             Points[0].Y - (Math.Cos(18 * Math.PI / 180) + Math.Sin(72 * Math.PI / 180)) * a);
             Console.WriteLine("My square is now " + Square);   
         }
        
    }

}