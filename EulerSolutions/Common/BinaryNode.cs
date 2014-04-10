namespace EulerSolutions.Common
{
    public class BinaryNode<TValue> : IBinaryNode<TValue>
    {
        public BinaryNode(int x, int y)
        {
            X = x;
            Y = y;
        }

        public BinaryNode(int x, int y, TValue value) : this(x, y)
        {
            Value = value;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public IBinaryNode<TValue> LeftNode { get; set; }
        public IBinaryNode<TValue> RightNode { get; set; }

        public TValue Value { get; set; }
    }
}