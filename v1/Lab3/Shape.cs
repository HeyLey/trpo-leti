using System;
/* 
Лаб3
   - Реализовать интерфейс IScalable реализующиц событие изменения площади
   - Реализовать изменение площади фигур при нажатии на кнопку на клавиатуре с последующем отображением в консоле
*/


namespace Lab3
{
    public abstract class Shape : IScalable
    {   
        protected Point[] Points { get; set; }
        protected string Name { get; set; }
        private string Color { get; set; }
        protected double Square{  get; set; }

        protected Shape(string color, Point[] points, double square, string name)
        {
            Color = color;
            Points = points;
            Square = square;
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Points:");
            foreach (var p in Points)
            {
                Console.WriteLine(p + " ");
            }

            Console.WriteLine("\n");
        }

        public virtual void Zoom2x()
        {
            throw new NotImplementedException();
        }
    }
}