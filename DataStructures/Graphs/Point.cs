namespace DataStructures.Graphs
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point p)
        {
            return Math.Sqrt(((X - p.X) * (X - p.X)) + ((Y - p.Y) * (Y - p.Y)));
        }
    }
}
