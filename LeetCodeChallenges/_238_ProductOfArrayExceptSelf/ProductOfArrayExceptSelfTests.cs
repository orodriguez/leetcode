namespace LeetCodeChallenges.Tests._238_ProductOfArrayExceptSelf;

public class ProductOfArrayExceptSelfTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    public void Test(int[] nums, int[] answer)
    {
        Assert.Equal(answer, ProductOfArrayExceptSelf(nums));
    }

    private int[] ProductOfArrayExceptSelf(int[] nums)
    {
        var answer = new int[nums.Length];

        var prefix = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix;
            prefix *= nums[i];
        }

        var postfix = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= postfix;
            postfix *= nums[i];
        }

        return answer;
    }
}