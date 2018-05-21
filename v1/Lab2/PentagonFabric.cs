namespace Lab2
{
    public class PentagonFabric
    {
        private static PentagonFabric instance;

        private PentagonFabric() {}
  
        public static PentagonFabric getInstance()
        {
            return instance ?? (instance = new PentagonFabric());
        }

        public Pentagon createPentagon(string color, Point upperPoint, double a)
        {
            return new Pentagon(color, upperPoint, a);
        }
    }
}