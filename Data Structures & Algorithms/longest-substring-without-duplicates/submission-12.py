class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        charSet = set()
        maxLen = 0
        l,r = 0, 0
        while r < len(s):
            while s[r] in charSet:
                charSet.discard(s[l])
                l+=1
            charSet.add(s[r])
            maxLen = max(maxLen, len(charSet))
            r+=1
        
        return maxLen
