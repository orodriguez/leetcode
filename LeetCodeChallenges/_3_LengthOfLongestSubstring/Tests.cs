namespace LeetCodeChallenges.Tests._3_LengthOfLongestSubstring;

public class Tests
{
    [Theory]
    [InlineData("", 0)]
    [InlineData("a", 1)]
    [InlineData("ab", 2)]
    [InlineData("aab", 2)]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void Test(string str, int expected)
    {
        var solution = new BruteForce();
        var result = solution.LengthOfLongestSubstring(str);
        Assert.Equal(expected, result);
    }
}

public interface ISolution
{
}

public class BruteForce : ISolution
{
    public int LengthOfLongestSubstring(string str)
    {
        if (str.Length == 0)
            return 0;
        var subStrings = str.Select((c, i) => Subs(new[] { c }, str.Skip(i + 1).ToArray()));
        return subStrings.Max(c => c.Length);
    }

    private char[] Subs(char[] currentSubString, char[] rest)
    {
        if (rest.Length == 0)
            return currentSubString;

        var currentChar = rest.First();

        if (!currentSubString.Contains(currentChar))
            return Subs(currentSubString.Concat(new[] { currentChar }).ToArray(), rest.Skip(1).ToArray());
        
        return currentSubString;
    }
}