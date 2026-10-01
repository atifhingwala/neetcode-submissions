class Solution:
    def validPalindrome(self, s: str) -> bool:
        for c in s:
            s1 = s.replace(c, "")
            if s1 == s1[::-1]:
                return True
        
        return False