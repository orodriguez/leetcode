using System.Collections;

namespace LeetCodeChallenges.Tests._155_MinStack;

public class MinStack
{
    private readonly Stack<int> _min;
    private readonly Stack<int> _values;

    public MinStack()
    {
        _min = new Stack<int>();
        _values = new Stack<int>();
    }

    public void Push(int val)
    {
        _values.Push(val);

        if (_min.Count == 0)
        {
            _min.Push(val);
            return;
        }
        
        if (val <= _min.Peek())
            _min.Push(val);
    }

    public void Pop()
    {
        if (_min.Peek() == _values.Peek())
            _min.Pop();

        _values.Pop();
    }

    public int Top() => _values.Peek();

    public int GetMin() => _min.Peek();
}