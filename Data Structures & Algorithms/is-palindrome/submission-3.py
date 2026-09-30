class Solution:
    def isPalindrome(self, s: str) -> bool:
        alpnumStr = ""
        for c in s:
            if c.isalnum():
                alpnumStr = alpnumStr + c
        
        alpnumStr= alpnumStr.lower()
        i = 0
        j = len(alpnumStr)-1
        while i < j:
            if alpnumStr[i] != alpnumStr[j]:
                return False
            i+=1
            j-=1
        
        return True

