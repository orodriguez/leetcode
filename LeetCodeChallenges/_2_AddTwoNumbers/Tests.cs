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
    [InlineData(new[] { 2, 4, 3 }, new[] { 5, 6, 4}, new[] { 7, 0, 8 })]
    public void Test(int[] l1, int[] l2, int[] expected) =>
        Assert.Equal(expected, Solution.AddTwoNumbers(ListNode.From(l1), ListNode.From(l2)));
}