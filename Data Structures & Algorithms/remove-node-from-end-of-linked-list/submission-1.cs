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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> nodes = new List<ListNode>();
        ListNode p = head;
        while (p != null)
        {
            nodes.Add(p);
            p = p.next;
        }
        
        if (nodes.Count < 2)
        {
            return null;
        }
        int m = nodes.Count - (n-1);
        if (m == 1)
        {
            head = nodes[m];
        }
        else
        {
            nodes[m-2].next = nodes[m-1].next;
        }

        return head;
    }
}
