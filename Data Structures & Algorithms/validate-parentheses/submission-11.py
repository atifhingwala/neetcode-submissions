class Solution:
    def isValid(self, s: str) -> bool:
        braces = {
            ')' : '(',
            '}' : '{',
            ']' : '['
        }
        stack = []

        for c in s:
            if c not in braces.keys():
                stack.append(c)
            else:
                if stack and stack[-1] == braces[c]:
                    stack.pop()
                else:
                    return False
        
        if stack:
            return False
        else:
            return True 

