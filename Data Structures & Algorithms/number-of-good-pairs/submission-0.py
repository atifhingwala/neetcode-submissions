class Solution:
    def numIdenticalPairs(self, nums: List[int]) -> int:
        unique = set()
        for i in range(len(nums)):
            for j in range(i+1, len(nums)):
                if nums[i] == nums[j]:
                    unique.add((i,j))
        return len(unique)
