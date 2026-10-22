# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def deleteDuplicates(self, head: Optional[ListNode]) -> Optional[ListNode]:
        values = []
        dummy = node = ListNode()
        while (head):
            if head.val not in values:
                values.append(head.val)
                node.next = head
                node = node.next
            head = head.next
        
        node.next = None
        
        return dummy.next