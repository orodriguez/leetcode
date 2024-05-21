namespace LeetCodeChallenges.Tests._739_DailyTemperatures;

public class DailyTemperaturesTests
{
    [Theory]
    [InlineData(new[] { 30 }, new[] { 0 })]
    [InlineData(new[] { 30, 31 }, new[] { 1, 0 })]
    [InlineData(new[] { 31, 30 }, new[] { 0, 0 })]
    [InlineData(new[] { 32, 31, 30, 33 }, new[] { 3, 2, 1, 0 })]
    [InlineData(new[] { 40, 30, 31 }, new[] { 0, 1, 0 })]
    [InlineData(new[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new[] { 1, 1, 4, 2, 1, 1, 0, 0 })]
    [InlineData(new[] { 30, 40, 50, 60 }, new[] { 1, 1, 1, 0 })]
    [InlineData(new[] { 30, 60, 90 }, new[] { 1, 1, 0 })]
    public void One(int[] temps, int[] expectedResult) => 
        Assert.Equal(expectedResult, DailyTemperatures(temps));

    private int[] DailyTemperatures(int[] temps)
    {
        var result = new int[temps.Length]; // default values will be zero
        var stack = new Stack<int>();
        for (var i = 0; i < temps.Length; i++)
        {
            // Monotonic Stack
            while (stack.Any() && temps[stack.Peek()] < temps[i])
            {
                var index = stack.Pop();
                result[index] = i - index;
            }
            stack.Push(i);
        }

        return result;
    }
}