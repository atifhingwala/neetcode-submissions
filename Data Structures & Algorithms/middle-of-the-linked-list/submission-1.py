# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def middleNode(self, head: Optional[ListNode]) -> Optional[ListNode]:
        headSample = head
        count = 0
        while head:
            count+=1
            head = head.next
        
        mid = count//2 +1
        
        count = 0
        while headSample:
            count+=1
            if count == mid:
                return headSample
            headSample = headSample.next
        
        return None
    

