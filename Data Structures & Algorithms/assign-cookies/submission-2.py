class Solution:
    def findContentChildren(self, g: List[int], s: List[int]) -> int:
        g.sort()
        s.sort()
        res = 0
        for i in g:
            for n, j in enumerate(s):
                if j >= i:
                    res+=1
                    s.remove(s[n])
                    break
        
        return res
                