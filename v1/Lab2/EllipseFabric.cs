namespace Lab2
{
    public class EllipseFabric
    {
        private static EllipseFabric instance;

        private EllipseFabric() {}

        public static EllipseFabric getInstance()
        {
            return instance ?? (instance = new EllipseFabric());
        }

        public Ellipse createEllipse(string color, Point center, double r1, double r2)
        {
            return new Ellipse(color, center, r1, r2);
        }
    }
}