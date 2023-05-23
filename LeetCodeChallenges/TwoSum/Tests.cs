using static LeetCodeChallenges.Tests.TwoSum.Solution;

namespace LeetCodeChallenges.Tests.TwoSum;

public class Tests
{
    [Theory]
    [InlineData(new int[0], 1, new int[0])]
    [InlineData(new[] { 1 }, 2, new int[0])]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void Test(int[] nums, int target, int[] expected) =>
        Assert.Equal(expected, Solution.TwoSum(nums, target));
}