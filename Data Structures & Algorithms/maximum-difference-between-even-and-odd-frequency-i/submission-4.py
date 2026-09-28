class Solution:
    def maxDifference(self, s: str) -> int:
        items = Counter(s)
        items = items.most_common()
        oddMax, evenMin = 0, float("inf")
        for item in items:
            if item[1] % 2 == 0:
                evenMin = min(evenMin, item[1])
            else:
                oddMax = max(oddMax, item[1])
        return (oddMax - evenMin)
        

                
        


