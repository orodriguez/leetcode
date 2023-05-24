namespace LeetCodeChallenges.Tests._2_AddTwoNumbers;

public class Tests
{
    [Theory]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 1 }, new[] { 2 }, new[] { 3 })]
    [InlineData(new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 5 })]
    [InlineData(new[] { 1, 2 }, new[] { 2 }, new[] { 3, 2 })]
    [InlineData(new[] { 5 }, new[] { 5 }, new[] { 0, 1 })]
    [InlineData(new[] { 1, 0, 1 }, new[] { 1, 0, 1 }, new[] { 2, 0, 2 })]
    [InlineData(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    public void Test(int[] l1, int[] l2, int[] expected)
    {
        var solution = new Solution();
        var result = solution.AddTwoNumbers(From(l1), From(l2));
        Assert.Equal(expected, ToArray(result));
    }

    private static int[] ToArray(ListNode list)
    {
        if (list.next == null)
            return new[] { list.val };

        return new[] { list.val }.Concat(ToArray(list.next)).ToArray();
    }

    private static ListNode From(int[] val)
    {
        if (!val.Any())
            throw new ArgumentException();

        if (val.Length == 1)
            return new ListNode(val[0]);

        return new ListNode(val.First(), From(val.Skip(1).ToArray()));
    }
}