class Solution:
    def isPalindrome(self, s: str) -> bool:
        alpnumStr = ""
        for c in s:
            if c.isalnum():
                alpnumStr += c.lower()
        
        return alpnumStr == alpnumStr[::-1]