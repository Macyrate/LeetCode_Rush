/*
 * @lc app=leetcode.cn id=206 lang=csharp
 *
 * [206] 反转链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        //空节点特殊条件
        if (head == null) return head;
        
        //利用堆栈，倒进倒出一次即进行反转
        Stack<ListNode> stack = new Stack<ListNode>();

        //注意如果用head.next作为条件，遍历不到最后一个节点
        while (head != null)
        {
            ListNode nextNode = head.next;
            head.next = null;       //记得清除节点的后驱，否则会成环
            stack.Push(head);
            head = nextNode;
        }

        ListNode retHead = stack.Pop();     //需要记录下反转后的头结点
        ListNode here = retHead;
        while (stack.Any())
        {
            here.next = stack.Pop();
            here = here.next;
        }

        return retHead;
    }
}
// @lc code=end

