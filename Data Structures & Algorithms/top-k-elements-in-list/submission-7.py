class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        d = defaultdict(int)
        for num in nums:
            d[num] += 1
        d = dict(sorted(d.items(), key=lambda item: item[1], reverse=True))
        result = []
        for i,(key,v) in enumerate(d.items(), start=1):
            if i <= k:
                result.append(key)
            else:
                break
        
        return result

