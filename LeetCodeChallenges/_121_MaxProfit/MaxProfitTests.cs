namespace LeetCodeChallenges.Tests._121_MaxProfit;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
public class MaxProfitTests
{
    [Theory]
    [InlineData(new[] { 1 }, 0)]
    [InlineData(new[] { 1, 2 }, 1)]
    [InlineData(new[] { 1, 1, 2 }, 1)]
    [InlineData(new[] { 10, 5, 12, 15, 6, 25, 3, 10 }, 20)]
    [InlineData(new[] { 3, 2, 1 }, 0)]
    public void Test(int[] prices, int expectedProfit)
    {
        var solution = new Solution();
        Assert.Equal(expectedProfit, solution.MaxProfit(prices));
    }
}

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        
        var left = 0;
        var right = 1;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                var profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
                left = right;

            right++;
        }

        return maxProfit;
    }
}