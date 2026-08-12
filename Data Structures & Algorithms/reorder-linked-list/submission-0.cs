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
    public void ReorderList(ListNode head) {
        List<ListNode> nodes = new List<ListNode>();
        ListNode p = head;
        while (p != null)
        {
            nodes.Add(p);
            p = p.next;
        }

        int i = 0;
        int j = nodes.Count - 1;
        while (i < j)
        {
            nodes[i].next = nodes[j];
            i++;
            nodes[j].next = nodes[i];
            j--;
        }

        nodes[i].next = null;
    }
}
