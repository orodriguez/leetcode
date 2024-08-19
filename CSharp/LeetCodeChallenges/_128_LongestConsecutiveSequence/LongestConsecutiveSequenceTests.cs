// ReSharper disable InvalidXmlDocComment

namespace LeetCodeChallenges.Tests._128_LongestConsecutiveSequence;

/**
 * 128. Longest Consecutive Sequence
 * Medium
 * Topics
 * Companies
 * Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
 * 
 * You must write an algorithm that runs in O(n) time.
 * 
 *  
 * 
 * Example 1:
 * 
 * Input: nums = [100,4,200,1,3,2]
 * Output: 4
 * Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
 * Example 2:
 * 
 * Input: nums = [0,3,7,2,5,8,4,6,0,1]
 * Output: 9
 *  
 * 
 * Constraints:
 * 
 * 0 <= nums.length <= 105
 * -109 <= nums[i] <= 109 
 */
public class LongestConsecutiveSequenceTests
{
    [Theory]
    [InlineData(new int[0], 0)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 1, 2 }, 2)]
    [InlineData(new[] { 100, 4, 200, 1, 3, 2 }, 4)]
    [InlineData(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
    public void Tests(int[] nums, int expected) =>
        Assert.Equal(expected, LongestConsecutiveSequence(nums));

    private int LongestConsecutiveSequence(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var longest = 0;

        foreach (var n in set)
        {
            if (set.Contains(n - 1)) continue;

            var length = 0;
            while (set.Contains(n + length))
                length += 1;
            longest = Math.Max(longest, length);
        }

        return longest;
    }
}