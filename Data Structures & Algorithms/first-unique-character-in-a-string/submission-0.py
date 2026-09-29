class Solution:
    def firstUniqChar(self, s: str) -> int:
        unique = Counter(s)
        uniqList = [item for item, count in unique.items() if count == 1]
        res = float("inf")
        for i in uniqList:
            res = min(res, s.index(i))
        
        if (res == float("inf")):
            return -1
        else:
            return res

        




