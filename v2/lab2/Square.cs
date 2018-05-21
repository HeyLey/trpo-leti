namespace Shapes
{
    public class Square : Rectangle
    {

        public Square(Point upperRightPoint, double a) : base(upperRightPoint, a, a)
        {
            Name = "SQUARE";
        } 
               
    }
}