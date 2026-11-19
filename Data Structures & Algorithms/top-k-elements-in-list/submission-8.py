class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        freq = Counter(nums).most_common(k)
        
        res = []
        for n in freq:
            res.append(n[0])
        
        return res


