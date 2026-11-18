class Solution:
    def maxAscendingSum(self, nums: List[int]) -> int:
        res = nums[0]
        l = len(nums)
        
        for i in range(l):
            curr = nums[i]
            for j in range(i+1, l):
                if nums[j-1] >= nums[j]:
                    break
                curr += nums[j]
            res = max(res, curr)
        
        return res
            
            
        
