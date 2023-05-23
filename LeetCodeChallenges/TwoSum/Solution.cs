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
            if (seen.ContainsKey(complement))
                return new[] { seen[complement], i };
            seen[current] = i;
        }

        return Array.Empty<int>();
    }
}