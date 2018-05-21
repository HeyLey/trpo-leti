namespace Lab2
{
    public class Square : Rectangle 
    {
        internal Square(string color, Point lowerLeftPoint, double a) : base(color, lowerLeftPoint, a, a)
        {
            Name = "SQUARE";
        }   
    }
}