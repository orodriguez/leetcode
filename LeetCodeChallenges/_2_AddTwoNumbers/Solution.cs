using System.Collections;
using System.Xml;

namespace LeetCodeChallenges.Tests._2_AddTwoNumbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
    {
        var sum = l1.val + l2.val + carry;
        var newCarry = sum / 10;
        var newVal = sum % 10;

        if (l1.next == null && l2.next == null && newCarry == 0)
            return new ListNode(newVal);

        return new ListNode(sum % 10, 
            AddTwoNumbers(l1.next ?? new ListNode(), l2.next ?? new ListNode(), newCarry));
    }
}

public class ListNode
{
    public static ListNode Zero => new ListNode(0, null);
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}