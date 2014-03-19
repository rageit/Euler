using System.Globalization;
using EulerSolutions.Common;

namespace EulerSolutions.Problems
{
    public class Problem15 : IProblemSolver
    {
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
            const int maxDim = 20;
            _pathCount = 0;

            //var baseNode = ConstructGraph(maxDim, maxDim);
            var baseNode = new Node(0, 0);

            Traverse(baseNode, maxDim, maxDim);

            return _pathCount.ToString(CultureInfo.InvariantCulture);
        }

        private void Traverse(Node node, int xDim, int yDim)
        {
            // Reached the goal node
            if (node.X == xDim - 1 && node.Y == yDim - 1)
            {
                _pathCount++;
                return;
            }

            if (node.X < xDim - 1)
            {
                Traverse(new Node(node.X + 1, node.Y), xDim, yDim);
            }
            if (node.Y < yDim - 1)
            {
                Traverse(new Node(node.X, node.Y + 1), xDim, yDim);
            }
        }

        private Node ConstructGraph(int xDim, int yDim)
        {
            var baseNode = new Node(0, 0);
            AddNode(baseNode, xDim, yDim);

            return baseNode;
        }

        private void AddNode(Node currentNode, int xDim, int yDim)
        {
            if (currentNode.X < xDim - 1)
            {
                var leftChildNode = new Node(currentNode.X + 1, currentNode.Y);
                currentNode.LeftNode = leftChildNode;

                AddNode(currentNode.LeftNode, xDim, yDim);
            }

            if (currentNode.Y < yDim - 1)
            {
                var rightChildNode = new Node(currentNode.X, currentNode.Y + 1);
                currentNode.RightNode = rightChildNode;

                AddNode(currentNode.RightNode, xDim, yDim);
            }
        }

        class Node
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }

            public Node(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}