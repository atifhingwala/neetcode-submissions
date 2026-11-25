class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        chars = set()
        res = 0
        l, r = 0, 0
        while r < len(s):
            if s[r] in chars:
                while s[r] in chars:
                    chars.remove(s[l])
                    l+=1
            chars.add(s[r])
            r+=1
            res = max(res, len(chars))
        
        return res

