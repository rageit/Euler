using System.Globalization;
using EulerSolutions.Common;

namespace EulerSolutions.Problems
{
    public class Problem15 : IProblemSolver<string>
    {
        private static readonly object Lock = new object();
        private static long _pathCount;

        public string Title
        {
            get { return "Lattice paths"; }
        }

        public string Definition
        {
            get
            {
                return "Starting in the top left corner of a 2×2 grid, " +
                       "and only being able to move to the right and down, " +
                       "there are exactly 6 routes to the bottom right corner. " +
                       "How many such routes are there through a 20×20 grid?";
            }
        }

        /// This can be solved by traversing the graph structure recursively. 
        /// Example of graph for 2x2 matrix
        ///                  0,0
        ///             0,1       1,0
        ///         2,0      1,1       0,2
        ///             2,0       1,2
        ///                  2,2
        public string Solve()
        {
            const int maxDim = 21;
            _pathCount = 0;

            //// Constructing graph and then traversing it consumes a lot of memory
            var baseNode = new BinaryNode<string>(0, 0);

            //// Using graph traversal
            Traverse(baseNode, maxDim, maxDim);

            //_pathCount = FindPaths(20, 20);

            return _pathCount.ToString(CultureInfo.InvariantCulture);
        }

        private void Traverse(IBinaryNode<string> node, int xDim, int yDim)
        {
            // Reached the goal node
            if (node.X == xDim - 1 && node.Y == yDim - 1)
            {
                lock (Lock)
                {
                    _pathCount++;
                }
                return;
            }

            if (node.X < xDim - 1)
            {
                Traverse(new BinaryNode<string>(node.X + 1, node.Y), xDim, yDim);
            }
            if (node.Y < yDim - 1)
            {
                Traverse(new BinaryNode<string>(node.X, node.Y + 1), xDim, yDim);
            }
        }

        public long FindPaths(int rows, int columns)
        {
            var paths = new long[rows + 1, columns + 1];

            for (int row = 0; row <= rows; row++)
            {
                for (int column = 0; column <= columns; column++)
                {
                    if (row == 0 || column == 0)
                        paths[row, column] = 1;
                    else
                        paths[row, column] = paths[row - 1, column] + paths[row, column - 1];
                }
            }

            return paths[rows, columns];
        }
    }
}