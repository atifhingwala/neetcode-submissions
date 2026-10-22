# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def deleteDuplicates(self, head: Optional[ListNode]) -> Optional[ListNode]:
        nodes = []
        while (head != None):
            nodes.append(head.val)
            head = head.next
        
        nodesSet = sorted(list(set(nodes)))
        dummy = start = ListNode()
        for i in range(len(nodesSet)):
            temp = ListNode(nodesSet[i], None)
            start.next = temp
            start = start.next
        
        return dummy.next

