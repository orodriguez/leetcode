namespace LeetCodeChallenges.Tests._217_ContainsDuplicate;

public class ContainsDuplicateTest
{
    [Theory]
    [InlineData(new int[0], false)]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void Test(int[] input, bool expectedResult)
    {
        Assert.Equal(expectedResult, input.ContainsDuplicate());
    }
}