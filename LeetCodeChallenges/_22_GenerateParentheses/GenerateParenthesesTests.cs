using System.Collections;

namespace LeetCodeChallenges.Tests._22_GenerateParentheses;

public class GenerateParenthesesTests
{
    [Theory]
    [InlineData(1, new[] { "()" })]
    [InlineData(2, new[] { "(())", "()()" })]
    [InlineData(3, new[] { "((()))","(()())","(())()","()(())","()()()" })]
    public void Tests(int n, string[] result) => 
        Assert.Equal(result, GenerateParentheses(n));

    [Fact]
    public void Append()
    {
        var stack = new Stack<char>();
        stack.Push('a');
        stack.Push('b');
        
        Assert.Equal("ab", string.Join("", stack.Reverse()));
    }

    private string[] GenerateParentheses(int n)
    {
        var stack = new Stack<char>();
        var results = new List<string>();
        
        BackTrack(0, 0);

        void BackTrack(int open, int close)
        {
            if (open == close && close == n)
            {
                results.Add(string.Join("", stack.Reverse()));
                return;
            }

            if (open < n)
            {
                stack.Push('(');
                BackTrack(open + 1, close);
                stack.Pop();
            }

            if (close < open)
            {
                stack.Push(')');
                BackTrack(open, close + 1);
                stack.Pop();
            }
        }

        return results.ToArray();
    }
}