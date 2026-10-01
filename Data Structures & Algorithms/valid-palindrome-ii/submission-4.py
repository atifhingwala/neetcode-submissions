class Solution:
    def validPalindrome(self, s: str) -> bool:
        removeChar = []
        i, j = 0, len(s)-1
        while (i<j):
            if s[i] != s[j]:
                s1 = s.replace(s[i], "")
                s2 = s.replace(s[j], "")
                return s1 == s1[::-1] or s2 == s2[::-1]
            i+=1
            j-=1
        
        return True
        
                
