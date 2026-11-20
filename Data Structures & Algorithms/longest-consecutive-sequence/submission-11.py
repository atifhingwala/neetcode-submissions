class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if len(nums) == 0:
            return 0
        noDup = sorted(list(set(nums)))
        maxRes = 1
        res = 1
        for i in range(1, len(noDup)):
            if noDup[i-1] + 1 == noDup[i]:
                res+=1
            else:
                res = 1
            maxRes = max(res, maxRes)
        

        return maxRes
            
            
            