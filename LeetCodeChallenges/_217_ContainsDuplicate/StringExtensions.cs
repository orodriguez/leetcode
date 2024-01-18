namespace LeetCodeChallenges.Tests._217_ContainsDuplicate;

public static class StringExtensions
{
    public static bool ContainsDuplicate(this int[] nums)
    {
        var hashSet = new HashSet<int>(nums);
        return hashSet.Count != nums.Length;
    }

    // O(s + t)
    public static bool IsAnagramTwoDictionaries(this string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var countS = new Dictionary<char, int>();
        var countT = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            countS[s[i]] = countS.GetValueOrDefault(s[i]) + 1;
            countT[t[i]] = countT.GetValueOrDefault(t[i]) + 1;
        }

        return countS.All(pair => countS[pair.Key] == countT.GetValueOrDefault(pair.Key));
    }

    public static bool IsAnagramSorting(this string s, string t) => 
        s.Order().SequenceEqual(t.Order());
}