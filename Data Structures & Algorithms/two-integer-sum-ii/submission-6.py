class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        d = defaultdict(int)
        for i,n in enumerate(numbers):
            val = target - n
            if d[val]:
                return [d[val], i+1]
            d[n] = i+1
        
        return []