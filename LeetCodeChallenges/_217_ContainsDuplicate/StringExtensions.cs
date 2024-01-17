namespace LeetCodeChallenges.Tests._217_ContainsDuplicate;

public static class StringExtensions
{
    public static bool ContainsDuplicate(this int[] nums)
    {
        var hashSet = new HashSet<int>(nums);
        return hashSet.Count != nums.Length;
    }
}