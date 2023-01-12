using DataStructures.Graphs;

namespace TSP.Heuristics
{
    public interface ITspHeuristic
    {
        Point[] Solve(Point[] points);
    }
}
