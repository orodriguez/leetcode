namespace LeetCodeChallenges.Tests._853_CarFleet;

public class CarFleetTests
{
    [Theory]
    [InlineData(1, new[] { 0 }, new[] { 1 }, 1)]
    [InlineData(10, new[] { 3 }, new[] { 3 }, 1)]
    [InlineData(100, new[] { 0, 2, 4 }, new[] { 4, 2, 1 }, 1)]
    [InlineData(12, new[] { 10, 8, 0, 5, 3 }, new[] { 2, 4, 1, 1, 3 }, 3)]
    [InlineData(12, new[] { 0, 3, 5, 8, 10 }, new[] { 1, 3, 1, 4, 2 }, 3)]
    [InlineData(6, new[] { 0, 2, 3 }, new[] { 1, 2, 3 }, 3)]
    [InlineData(6, new[] { 0, 2, 3 }, new[] { 6, 3, 1 }, 1)]
    [InlineData(10, new[] { 0, 1, 2, 5, 0 }, new[] { 10, 9, 8, 1, 2 }, 1)]
    public void Test(int target, int[] position, int[] speed, int output) =>
        Assert.Equal(output, CarFleet(target, position, speed));

    // With monotonic stack
    private int CarFleet(int target, int[] position, int[] speed)
    {
        Array.Sort(position, speed);

        var times = new double[position.Length];
        for (var i = 0; i < position.Length; i++) 
            times[i] = (double)(target - position[i]) / speed[i];

        var stack = new Stack<double>();
        for (var i = 0; i < position.Length; i++)
        {
            while (stack.Any() && times[i] >= stack.Peek())
                stack.Pop();
            
            stack.Push(times[i]);
        }

        return stack.Count();
    }
}