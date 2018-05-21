namespace Lab1
{
    public class Square : Rectangle
    {
        public Square(string color, Point upperRightPoint, double a) : base(color, upperRightPoint, a, a)
        {
            Name = "SQUARE";
        } 
    }
}