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
        List<ListNode> lst = new List<ListNode>();
        ListNode p = head;
        while (p != null)
        {
            
            if (lst.Contains(p))
            {
                return true;
            }
            else
            {
                lst.Add(p);
            }
            p = p.next;
        }

        return false;
    }
}
