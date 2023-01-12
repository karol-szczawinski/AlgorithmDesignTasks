using DataStructures.Graphs;
using TSP.Heuristics;


public static partial class Program
{
    public static void Main()
    {
        var graph = new Point[] { new Point(0, 0), new Point(1, 0), new Point(-2, 0), new Point(6, 0), new Point(-10, 0), new Point(25, 0) };

        var result = new NearestNeighbor().Solve(graph);

        Console.WriteLine("Result for nearest-neighbor heuristics: {0}", CalculatePathLength(result));

    }

    public static double CalculatePathLength(Point[] points)
    {
        double length = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            length += points[i].Distance(points[i + 1]);
        }

        length += points[points.Length - 1].Distance(points[0]);

        return length;
    }
}

