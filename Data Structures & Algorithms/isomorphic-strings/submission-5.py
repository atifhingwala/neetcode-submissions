class Solution:
    def isIsomorphic(self, s: str, t: str) -> bool:
        if len(s) != len(t) or len(set(s)) != len(set(t)):
            return False
        uniqueChar = set(s)
        uniqueSet = set()
        for i in range(len(s)):
            uniqueSet.add((s[i], t[i]))
        
        return len(uniqueSet) == len(uniqueChar)


