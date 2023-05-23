namespace LeetCodeChallenges.Tests.TwoSum;

public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            var complement = target - current;
            if (seen.TryGetValue(complement, out var seenValue))
                return new[] { seenValue, i };
            seen[current] = i;
        }

        return Array.Empty<int>();
    }
}