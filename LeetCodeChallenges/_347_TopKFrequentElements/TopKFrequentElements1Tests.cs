namespace LeetCodeChallenges.Tests._347_TopKFrequentElements;

public class TopKFrequentElements1Tests
{
    [Theory]
    [InlineData(new[] { 1 }, 1, new[] { 1 })]
    [InlineData(new[] { 1, 1, 1, 2, 2, 3 }, 2, new[] { 1, 2 })]
    public void Test(int[] nums, int k, int[] output) =>
        Assert.Equal(output.Order(), TopKFrequentElements(nums, k).Order());
    
    // O(n + s)
    private int[] TopKFrequentElements(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();
        foreach (var n in nums) 
            freq[n] = freq.GetValueOrDefault(n) + 1;
        
        var topK = freq
            .OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();

        return topK;
    }
}