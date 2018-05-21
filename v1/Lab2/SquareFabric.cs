namespace Lab2
{
    public class SquareFabric
    {
    private static SquareFabric instance;

    private SquareFabric() {}

    public static SquareFabric getInstance()
    {
        return instance ?? (instance = new SquareFabric());
    }

    public Square createSquare(string color, Point lowerLeftPoint, double a)
    {
        return new Square(color, lowerLeftPoint, a);
    }
    }
}