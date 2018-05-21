﻿using System;

namespace Lab1
{
    public class Pentagon : Shape
    {

        public Pentagon(string color, Point upperLeftPoint, double a) : base(color, 
            new[] {
                upperLeftPoint,
                new Point(upperLeftPoint.X + a, upperLeftPoint.Y),
                new Point(upperLeftPoint.X - Math.Sin(18*Math.PI/180)*a, upperLeftPoint.Y - Math.Cos(18*Math.PI/180)*a),
                new Point(upperLeftPoint.X + a + Math.Sin(18*Math.PI/180)*a, upperLeftPoint.Y - Math.Cos(18*Math.PI/180)*a),
                new Point(upperLeftPoint.X + a/2, upperLeftPoint.Y - (Math.Cos(18*Math.PI/180) + Math.Sin(72*Math.PI/180))*a)                                                                               
            },
            "PENTAGON")
        { }
    }
}