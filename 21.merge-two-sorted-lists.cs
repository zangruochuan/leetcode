/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 *
 * https://leetcode-cn.com/problems/merge-two-sorted-lists/description/
 *
 * algorithms
 * Easy (51.31%)
 * Total Accepted:    38.7K
 * Total Submissions: 74.9K
 * Testcase Example:  '[1,2,4]\n[1,3,4]'
 *
 * 将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
 * 
 * 示例：
 * 
 * 输入：1->2->4, 1->3->4
 * 输出：1->1->2->3->4->4
 * 
 * 
 */
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode returnl = null;
        ListNode l = null;
        if (l1 != null || l2 != null)
        {
            if (l1 == null||(l2!=null&&l1.val>l2.val))
            {
                returnl = new ListNode(l2.val);
                l2 = l2.next;
                l = returnl;
            }
            else 
            {
                returnl = new ListNode(l1.val);
                l1 = l1.next;
                l = returnl;
            }
        }
        else
        {
            return returnl;
        }
        while (l1 != null || l2 != null)
        {
            if (l1 == null || (l2!=null &&l1.val > l2.val))
            {
                l.next = new ListNode(l2.val);
                l2 = l2.next;
                l = l.next;
            }
            else
            {
                l.next = new ListNode(l1.val);
                l1 = l1.next;
                l = l.next;
            }
        }
        return returnl;
    }
}
