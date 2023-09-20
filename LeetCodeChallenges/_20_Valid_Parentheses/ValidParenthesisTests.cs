namespace LeetCodeChallenges.Tests._20_Valid_Parentheses;

public class Solution
{
    public static bool IsValid(string input)
    {
        var expectedAfter = new Dictionary<char, char>
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };
        
        var expectedTokens = new Stack<char>();

        foreach (var chr in input)
        {
            if (expectedAfter.TryGetValue(chr, out var expected))
            {
                expectedTokens.Push(expected);
                continue;
            }

            if (!expectedAfter.ContainsValue(chr)) continue;

            if (expectedTokens.Count == 0)
                return false;
            
            if (expectedTokens.Pop() != chr)
                return false;
        }
        
        return expectedTokens.Count == 0;
    }
}

public class ValidParenthesisTests
{
    [Theory]
    [InlineData("", true)]
    [InlineData("()", true)]
    [InlineData("()()", true)]
    [InlineData("(This (is) good )", true)]
    [InlineData("(){}[]", true)]
    [InlineData("[(())({})]([])", true)]
    [InlineData("(", false)]
    [InlineData("((", false)]
    [InlineData("(This (is) not good", false)]
    [InlineData("({[})", false)]
    [InlineData(")()", false)]
    [InlineData("(}", false)]
    [InlineData("(})", false)]
    public void Valid(string input, bool expectedResult)
    {
        Assert.Equal(Solution.IsValid(input), expectedResult);
    }
}