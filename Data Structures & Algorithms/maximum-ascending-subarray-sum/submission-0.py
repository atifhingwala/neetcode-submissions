class Solution:
    def maxAscendingSum(self, nums: List[int]) -> int:
        maxSum = nums[0]
        currSum = nums[0]
        n = len(nums)
        for i in range(n-1):
            if nums[i+1] > nums[i]:
                currSum += nums[i+1]
            else:
                maxSum = max(maxSum, currSum)
                currSum = nums[i+1]
        
        return max(maxSum, currSum)


