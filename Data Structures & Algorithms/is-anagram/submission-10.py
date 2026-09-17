class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        sList = sorted(list(s))
        tList = sorted(list(t))
        for i,j in zip(sList, tList):
            if i == j:
                continue
            else:
                return False

        return True
