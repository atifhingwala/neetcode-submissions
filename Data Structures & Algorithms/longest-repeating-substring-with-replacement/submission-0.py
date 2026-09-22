class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        d = defaultdict(int)
        maxF = 0
        l=0
        res = 0
        for r in range(len(s)):
            d[s[r]]+=1
            maxF = max(maxF, d[s[r]])

            while (r-l+1) - maxF > k:
                d[s[l]]-=1
                l+=1
            
            res = max(res, r-l+1)
        
        return res
            


                

                

