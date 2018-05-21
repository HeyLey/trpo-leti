namespace Shapes
{
    public class Circle : Ellipse
    {

        public Circle(Point p, double r) : base(p, r, r)
        {
            Name = "CIRCLE";
        }

        public override string ToString()
        {
            var str = Name + "\n" + "Center: " + center + "\n" + "Radius 1: " + r1 + "\n";
            return str;
        }
    }
}
