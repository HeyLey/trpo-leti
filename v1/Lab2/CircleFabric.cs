namespace Lab2
{
    public class CircleFabric
    {
        private static CircleFabric instance;

        private CircleFabric() {}

        public static CircleFabric getInstance()
        {
            return instance ?? (instance = new CircleFabric());
        }

        public Circle createCircle(string color, Point center, double r1)
        {
            return new Circle(color, center, r1);
        }
    }
}