namespace EulerSolutions.Common
{
    public interface IBinaryNode<TValue>
    {
        int X { get; }
        int Y { get; }

        IBinaryNode<TValue> LeftNode { get; set; }
        IBinaryNode<TValue> RightNode { get; set; }

        TValue Value { get; set; }
    }
}