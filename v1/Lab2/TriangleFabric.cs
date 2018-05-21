namespace Lab2
{
    public class TriangleFabric
    {
        private static TriangleFabric instance;

        private TriangleFabric() {}

        public static TriangleFabric getInstance()
        {
            return instance ?? (instance = new TriangleFabric());
        }

        public Triangle createTriangle(string color, Point rightPoint, Point upperPoint, Point leftPoint)
        {
            return new Triangle(color, rightPoint, upperPoint, leftPoint);
        }
    }

}