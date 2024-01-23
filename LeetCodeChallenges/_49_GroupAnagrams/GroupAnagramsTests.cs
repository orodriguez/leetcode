namespace LeetCodeChallenges.Tests._49_GroupAnagrams;

public class GroupAnagramsTests
{
    public static TheoryData<string[], IList<IList<string>>> TheoryData() =>
        new()
        {
            { new[] { "" }, new List<IList<string>> { new List<string> { "" } } },
            { new[] { "s" }, new List<IList<string>> { new List<string> { "s" } } },
            {
                new[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new List<IList<string>>
                {
                    new List<string> { "bat" },
                    new List<string> { "nat", "tan" },
                    new List<string> { "ate", "eat", "tea" }
                }
            }
        };


    [Theory]
    [MemberData(nameof(TheoryData))]
    public void GroupAnagrams(string[] input, IList<IList<string>> expected) => 
        Assert.Equal(BuildString(expected), BuildString(input.GroupAnagrams()));

    private string BuildString(IEnumerable<IList<string>> groups) => 
        string.Join(',', groups.Select(BuildString).Order());

    private static string BuildString(IList<string> list) => 
        string.Join(',', list.Order());
}