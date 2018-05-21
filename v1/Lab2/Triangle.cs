using System;

namespace Lab2
{
    public class Triangle : Shape
    {
            
        internal Triangle(string color, Point rightPoint, Point upperPoint, Point leftPoint) : base(color,
            new []{rightPoint, upperPoint, leftPoint},
            Math.Sqrt( 
                ( Point.Dist(rightPoint, leftPoint) + Point.Dist(leftPoint, upperPoint) + Point.Dist(upperPoint, rightPoint) ) / 2 * (
                    ( Point.Dist(rightPoint, leftPoint) + Point.Dist(leftPoint, upperPoint) + Point.Dist(upperPoint, rightPoint) ) / 2 - Point.Dist(rightPoint, leftPoint) ) * ( 
                    ( Point.Dist(rightPoint, leftPoint) + Point.Dist(leftPoint, upperPoint) + Point.Dist(upperPoint, rightPoint) ) / 2 - Point.Dist(leftPoint, upperPoint) ) * (
                    ( Point.Dist(rightPoint, leftPoint) + Point.Dist(leftPoint, upperPoint) + Point.Dist(upperPoint, rightPoint) ) / 2 - Point.Dist(upperPoint, rightPoint))
            ),
            "TRIANGLE"
        )
        { }
    }
}