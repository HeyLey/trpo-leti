/* 
Лаб3
   - Реализовать интерфейс IScalable реализующиц событие изменения площади
   - Реализовать изменение площади фигур при нажатии на кнопку на клавиатуре с последующем отображением в консоле
*/


using System;
using Shapes;

namespace lab3
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Point p = new Point(0, 0);
            IScalable ellipse = new Ellipse(p, 5, 5);
            IScalable pentagon = new Pentagon(p, 2);
            IScalable circle = new Circle(p, 5);
            IScalable rectangle = new Rectangle(p, 5, 2);
            IScalable square = new Square(p, 3);
           
         //   ellipse.AreaChanged += delegate (object pol, double area) { Console.WriteLine("{0}with area: {1}", pol, area); };


            square.AreaChanged += (pol, area) => Console.WriteLine("{0}with area: {1}", pol, area);
         //   pentagon.AreaChanged += delegate (object pol, double area) { Console.WriteLine("{0}with area: {1}", pol, area); };

            Console.Write("Press <Enter> to start event... ");
            while (Console.ReadKey().Key!= ConsoleKey.Enter) { }

            /*if (ellipse is Ellipse)
                ((Ellipse)ellipse).scale(2); */
            
           // if (pentagon is Pentagon)
             //   ((Pentagon)pentagon).scale(2);
            
            if (square is Square)
                ((Square)square).scale(2);

            Console.ReadKey();
            
        }
        
        private static void Method1(object o, double area)
        {}
        
    }
}