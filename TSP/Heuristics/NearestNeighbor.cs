using DataStructures.Graphs;

namespace TSP.Heuristics
{
    public class NearestNeighbor : ITspHeuristic
    {
        public Point[] Solve(Point[] points)
        {
            var isVisited = new bool[points.Length];
            var result = new Point[points.Length];

            var currentIndex = 0;
            var currentResultIndex = 0;
            isVisited[0] = true;
            result[currentResultIndex++] = points[0];

            for (var i = 1; i < points.Length; i++)
            {
                var closestNeighborIndex = GetClosestNeigbhor(points, currentIndex, isVisited);
                if (closestNeighborIndex > 0)
                {
                    result[currentResultIndex++] = points[closestNeighborIndex];
                    currentIndex = closestNeighborIndex;
                    isVisited[currentIndex] = true;
                }
                else
                {
                    return result;
                }
            }

            return result;
        }

        private int GetClosestNeigbhor(Point[] points, int currentIndex, bool[] isVisited)
        {
            double minDistance = double.MaxValue;
            var index = 0;

            for (var i = 1; i < points.Length; i++)
            {
                if (!isVisited[i])
                {
                    var distance = points[currentIndex].Distance(points[i]);
                    if (distance < minDistance)
                    {
                        index = i;
                        minDistance = distance;
                    }
                }
            }

            return index;
        }
    }
}
