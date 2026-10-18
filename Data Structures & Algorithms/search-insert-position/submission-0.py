class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:
        for i,n in enumerate(nums):
            if n == target:
                return i
            elif target < n:
                return i
        
        return len(nums)
                