class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        numSet = {}
        for i in range(len(nums)):
            diff = target - nums[i]
            if diff in numSet.keys() and numSet[diff] != i:
                return [numSet[diff], i]
            numSet[nums[i]] = i
        
        return []
