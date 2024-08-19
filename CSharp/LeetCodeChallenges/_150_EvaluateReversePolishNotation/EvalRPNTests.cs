namespace LeetCodeChallenges.Tests._150_EvaluateReversePolishNotation;

// https://leetcode.com/problems/evaluate-reverse-polish-notation/description/
public class EvalRPNTests
{
    [Theory]
    [InlineData(new[] { "2", "2", "+" }, 4)]
    [InlineData(new[] { "2", "1", "-" }, 1)]
    [InlineData(new[] { "2", "1", "+", "3", "*" }, 9)]
    [InlineData(new[] { "4", "13", "5", "/", "+" }, 6)]
    [InlineData(new[]
        {
            "10", "6", "9", "3", "+",
            "-11", "*",
            "/",
            "*",
            "17", "+",
            "5", "+"
        }
        , 22)]
    public void Evaluate(string[] tokens, int expected) =>
        Assert.Equal(expected, EvalRPN(tokens));

    private int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out var num))
            {
                stack.Push(num);
                continue;
            }

            var op2 = stack.Pop();
            var op1 = stack.Pop();
            var result = token switch
            {
                "+" => op1 + op2,
                "-" => op1 - op2,
                "*" => op1 * op2,
                _ => op1 / op2
            };
            stack.Push(result);
        }

        return stack.Pop();
    }
}