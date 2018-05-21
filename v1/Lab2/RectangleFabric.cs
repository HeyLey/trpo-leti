namespace Lab2
{
    public class RectangleFabric
    {
        private static RectangleFabric instance;

        private RectangleFabric() {}
  
        public static RectangleFabric getInstance()
        {
            return instance ?? (instance = new RectangleFabric());
        }

        public Rectangle createRectangle(string color, Point lowerLeftPoint, double a, double b)
        {
            return new Rectangle(color, lowerLeftPoint, a, b);
        }
    }
}