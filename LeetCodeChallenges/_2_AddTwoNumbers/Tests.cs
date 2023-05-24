namespace LeetCodeChallenges.Tests._2_AddTwoNumbers;

public class Tests
{
    [Fact]
    public void FromArray()
    {
        var array = new[] { 2, 4, 3 };
        var nodeList = ListNode.From(array);
        Assert.Equal(array, nodeList.ToEnumerable());
    }

    [Theory]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 1 }, new[] { 2 }, new[] { 3 })]
    [InlineData(new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 5 })]
    [InlineData(new[] { 1, 2 }, new[] { 2 }, new[] { 3, 2 })]
    [InlineData(new[] { 5 }, new[] { 5 }, new[] { 0, 1 })]
    [InlineData(new[] { 1, 0, 1 }, new[] { 1, 0, 1 }, new[] { 2, 0, 2 })]
    [InlineData(new[] { 9,9,9,9,9,9,9 }, new[] { 9,9,9,9 }, new[] { 8,9,9,9,0,0,0,1 })]
    public void Test(int[] l1, int[] l2, int[] expected) =>
        Assert.Equal(expected, Solution.AddTwoNumbers(ListNode.From(l1), ListNode.From(l2)));
}