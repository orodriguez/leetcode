using System.Collections;
using System.Xml;

namespace LeetCodeChallenges.Tests._2_AddTwoNumbers;

public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
    {
        var sum = l1.Val + l2.Val + carry;
        var newCarry = sum / 10;
        var newVal = sum % 10;

        if (l1.Next == null && l2.Next == null && newCarry == 0)
            return new ListNode(newVal, null);

        return new ListNode(sum % 10, 
            AddTwoNumbers(l1.Next ?? ListNode.Zero, l2.Next ?? ListNode.Zero, sum / 10));
    }
}

public class ListNode : IEnumerable<int>
{
    public static ListNode Zero => new ListNode(0, null);
    public int Val { get; }
    public ListNode? Next { get; set; }

    public ListNode(int val = 0, ListNode? next = null)
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