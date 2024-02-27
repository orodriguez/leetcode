using System.Diagnostics;

namespace LeetCodeChallenges.Tests._155_MinStack;

public class MinStackTests
{
    [Fact]
    public void GetMin_One()
    {
        var s = new MinStack();
        s.Push(1);
        Assert.Equal(1, s.GetMin());
    }
    
    [Fact]
    public void GetMin_3Values()
    {
        var s = new MinStack();
        s.Push(1);
        s.Push(-2);
        s.Push(3);
        Assert.Equal(-2, s.GetMin());
    }
    
    [Fact]
    public void GetMin_RemovesMin()
    {
        var s = new MinStack();
        s.Push(1);
        s.Push(2);
        s.Push(-3);
        s.Pop();
        Assert.Equal(1, s.GetMin());
    }
    
    [Fact]
    public void GetMin_CaseX()
    {
        var s = new MinStack();
        s.Push(0);
        s.Push(1);
        s.Push(0);
        
        Assert.Equal(0, s.GetMin());
        s.Pop();
        Assert.Equal(0, s.GetMin());
    }
    
    [Fact]
    public void Top()
    {
        var s = new MinStack();
        s.Push(1);
        s.Push(2);
        s.Push(-3);
        s.Pop();
        Assert.Equal(2, s.Top());
    }
}