/* Общее:
  - Создать иерархию классов: 
    - Прямоугольник, квадрат
    - Пятиугольник
*/


using System;
using Shapes;

namespace lab1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var p = new Point(0, 0);
            var rt = new Rectangle(p, 3, 4.5);
            var sq = new Square(p, 5);
            var pt = new Pentagon(p, 10);
            var el = new Ellipse(p, 5, 2);
            var ci = new Circle(p, 10);
            Console.WriteLine(rt);
            Console.WriteLine(sq);
            Console.WriteLine(pt);
            Console.WriteLine(el);
            Console.WriteLine(ci);
        }
    }
}