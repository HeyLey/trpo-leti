using System;
using System.Drawing;

namespace Shapes
{
    public abstract class Shape : IComparable
    {
        protected string Name;

        protected Shape(string name)
        {
            Name = name;
        }

        public abstract double GetArea();

        public int CompareTo(object obj)
        {
            var shape = obj as Shape;
            if (shape != null)
            {
                if (GetArea() < shape.GetArea())
                   return -1;
                if (GetArea() > shape.GetArea())
                    return 1;
                else
                    return 0;
            }
            
            throw new InvalidCastException("Can't compare Shape object with another type");
            
        }

        public void PrintArea()
        {
            Console.WriteLine(Name);
            Console.WriteLine(GetArea());
            Console.WriteLine();
        }

    }
}
