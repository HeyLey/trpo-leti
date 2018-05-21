namespace Lab2
{
    public class ParallelogramFabric
    {
        private static ParallelogramFabric instance;

        private ParallelogramFabric() {}
  
        public static ParallelogramFabric getInstance()
        {
            return instance ?? (instance = new ParallelogramFabric());
        }

        public Parallelogram createParallelogram(string color, Point lowerLeftPoint, double a, double b, double ang)
        {
            return new Parallelogram(color, lowerLeftPoint, a, b, ang);
        }
    }
}