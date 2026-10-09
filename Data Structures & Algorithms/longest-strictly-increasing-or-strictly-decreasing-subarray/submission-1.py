class Solution:
    def longestMonotonicSubarray(self, nums: List[int]) -> int:
        IncRes = 1
        IncCount = 1
        for i,n in enumerate(nums):
            if i < len(nums)-1 and nums[i+1] > nums[i]:
                IncCount+=1
            else:
                IncRes = max(IncRes, IncCount)
                IncCount = 1
        
        DecRes = 1
        DecCount = 1
        for j,m in enumerate(nums):
            if j < len(nums)-1 and nums[j+1] < nums[j]:
                DecCount+=1
            else:
                DecRes = max(DecRes, DecCount)
                DecCount = 1
        
        return max(IncRes, DecRes)
        

                
