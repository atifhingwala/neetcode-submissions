class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        maxCount = 0
        count = 0
        for n in nums:
            if n == 1:
                count+=1
                continue
            maxCount = max(maxCount, count)
            count = 0
        maxCount = max(maxCount, count)
                
        
        return maxCount
