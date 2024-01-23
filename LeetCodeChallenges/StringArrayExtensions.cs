namespace LeetCodeChallenges.Tests;

public static class StringArrayExtensions
{
    public static IList<IList<string>> GroupAnagrams(this string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();
        foreach (var current in strs)
        {
            var sorted = Sort(current);

            if (groups.TryGetValue(sorted, out var group))
                group.Add(current);
            else
                groups[sorted] = new List<string> { current };
        }

        return groups.Values.ToList();
    }

    private static string Sort(string current)
    {
        var chars = current.ToCharArray();
        Array.Sort(chars);
        var sorted = new string(chars);
        return sorted;
    }
}