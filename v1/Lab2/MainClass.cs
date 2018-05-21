using System;
using System.Linq;
using Lab2;

/*- Реализовать набор фабрик для создания объектов
   - Хранить все фабрики в Singleton'е
   - Отобразить все объекты заданной площади используя LINQ
*/
    
public static class MainClass
{
    public static void Main(string[] args)
    {
         var p = new Point(0, 0);
         Shape[] shapes =
         {
              PentagonFabric.getInstance().createPentagon("red", p, 1),
              ParallelogramFabric.getInstance().createParallelogram("blue", p, 2, 1, 0.5236),
              RectangleFabric.getInstance().createRectangle("rose", p, 2, 0.5),
              SquareFabric.getInstance().createSquare("green", p, 1),
              TriangleFabric.getInstance().createTriangle("black", p, new Point(1, 0), new Point(0, 2)),
              EllipseFabric.getInstance().createEllipse("white", p, 1, 2),
              CircleFabric.getInstance().createCircle("yellow", p, 1)
         };

         var squares = new double[shapes.Length];
         var i = 0;
         foreach (var s in shapes)
         {
              //  s.Print();
              squares[i] = Math.Round(s.GetSquare(), 4);
              i++;
         }

         foreach (var s in squares)
         {
             Console.WriteLine(s);
         } 
         Console.WriteLine("\n");

         const int SQ = 1;
         Console.WriteLine("Search: square > " + SQ + "\n");
            
         var selected = from sh in shapes 
             where Math.Round(sh.GetSquare(), 4) > (SQ) 
             select sh;

        foreach (var s in selected)
        {
            s.Print();
            Console.WriteLine(s.GetSquare());
        }
    }
}