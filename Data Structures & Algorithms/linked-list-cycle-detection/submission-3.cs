/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        List<ListNode> nodes = new List<ListNode>();
        ListNode p = head;
        while (p != null)
        {
            if (nodes.Contains(p))
            {
                return true;
            }
            else
            {
                nodes.Add(p);
                p = p.next;
            }
        }

        return false;
    }
}
