namespace LeetCodeChallenges.Tests._242_ValidAnagram;

public abstract class AbstractValidAnagramTests
{
    protected abstract Func<string, string, bool> IsAnagram { get; }

    [Theory]
    [InlineData("a", "a", true)]
    [InlineData("ab", "ba", true)]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("a", "ab", false)]
    [InlineData("ab", "a", false)]
    [InlineData("rat", "cat", false)]
    public void Test(string s, string t, bool result) => 
        Assert.Equal(result, IsAnagram(s, t));
}