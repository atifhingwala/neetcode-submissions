class Solution:
    def pivotIndex(self, nums: List[int]) -> int:
        for i in range(len(nums)):
            leftSum , rightSum = 0, 0
            for j in range(i):
                leftSum = leftSum + nums[j]
            for k in range(i+1, len(nums)):
                rightSum = rightSum + nums[k]
            if leftSum == rightSum:
                return i
        
        return -1