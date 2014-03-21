namespace EulerSolutions.Common
{
    public class BinaryGraph<TValue>
    {
        public IBinaryNode<TValue> ConstructNode(IBinaryNode<TValue> node, int xDim, int yDim)
        {
            var baseNode = new BinaryNode<TValue>(0, 0);
            AddNode(baseNode, xDim, yDim);

            return baseNode;
        }

        private void AddNode(IBinaryNode<TValue> currentNode, int xDim, int yDim)
        {
            if (currentNode.X < xDim - 1)
            {
                var leftChildNode = new BinaryNode<TValue>(currentNode.X + 1, currentNode.Y);
                currentNode.LeftNode = leftChildNode;

                AddNode(currentNode.LeftNode, xDim, yDim);
            }

            if (currentNode.Y < yDim - 1)
            {
                var rightChildNode = new BinaryNode<TValue>(currentNode.X, currentNode.Y + 1);
                currentNode.RightNode = rightChildNode;

                AddNode(currentNode.RightNode, xDim, yDim);
            }
        }
    }
}