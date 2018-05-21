/*- Реализовать набор фабрик для создания объектов
   - Хранить все фабрики в Singleton'е
   - Отобразить все объекты заданной площади используя LINQ
*/

using System;
using System.Collections.Generic;
using System.Linq;
using factories;
using Shapes;

namespace lab2
{
    class MainClass
    {
       
        static void Main(string[] args)
        {
            var p = new Point(0, 0);
            
            Shape[] shapes =
            {
                new PentagonFactory().CreatePentagon(p, 1), 
                new RectangleFactory().CreateRectangle(p, 2, 0.5), 
                new SquareFactory().CreateSquare(p, 1), 
                new EllipseFactory().CreateEllipse(p, 1, 2), 
                new CircleFactory().CreateCircle(p, 1)
            };
            
            foreach (var s in shapes)
            {
                s.PrintArea();
            } 
            Console.WriteLine("\n");
            
            
            const int SQ = 1;
            Console.WriteLine("Search: area > " + SQ + "\n");
            
            var selected = from sh in shapes 
                where sh.GetArea() > SQ 
                select sh;

            Console.WriteLine("Selected: \n" );
            foreach (var s in selected)
            {
                s.PrintArea();
            }
        }
    }
}