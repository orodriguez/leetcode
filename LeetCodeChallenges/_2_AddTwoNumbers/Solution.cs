using System.Collections;

namespace LeetCodeChallenges.Tests._2_AddTwoNumbers;

public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        throw new NotImplementedException();
    }
}

public class ListNode : IEnumerable<int>
{
    private int Val { get; }
    private ListNode? Next { get; set; }

    private ListNode(int val = 0, ListNode? next = null)
    {
        Val = val;
        Next = next;
    }

    public static ListNode From(int[] val)
    {
        if (!val.Any())
            throw new ArgumentException();

        if (val.Length == 1)
            return new ListNode(val[0]);

        return new ListNode(val.First(), From(val.Skip(1).ToArray()));
    }

    public IEnumerable<int> ToEnumerable()
    {
        if (Next == null)
            return new[] { Val };

        return new[] { Val }.Concat(Next.ToEnumerable());
    }

    public IEnumerator<int> GetEnumerator() => ToEnumerable().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}