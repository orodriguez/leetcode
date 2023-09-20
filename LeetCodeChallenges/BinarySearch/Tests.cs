namespace LeetCodeChallenges.Tests.BinarySearch;

public class Tests
{
    [Theory]
    [InlineData(new[] {1}, 1, 0)]
    [InlineData(new[] {1, 2}, 1, 0)]
    [InlineData(new[] {1, 2}, 2, 1)]
    [InlineData(new[] {1, 2, 3}, 1, 0)]
    [InlineData(new[] {1, 2, 3}, 2, 1)]
    [InlineData(new[] {1, 2, 3}, 3, 2)]
    [InlineData(new[] {1, 2, 3, 4}, 2, 1)]
    [InlineData(new[] {1, 2, 3, 4, 5, 6, 7}, 7, 6)]
    [InlineData(new[] {1, 2, 3, 4, 5, 6, 7}, 8, -1)]
    public void Test(int[] a, int e, int r)
    {
        Assert.Equal(r, a.BSearch(e));
    }
}

public static class ArrayExtensions
{
    public static int BSearch(this int[] array, int target)
    {
        var left = 0;
        var right = array.Length - 1;
        
        while (left <= right)
        {
            var middle = left + (right - left) / 2;
            if (array[middle] == target)
                return middle;

            if (array[middle] < target)
                left = middle + 1;
            else
                right = middle - 1;
        }
        
        return -1;
    }
}