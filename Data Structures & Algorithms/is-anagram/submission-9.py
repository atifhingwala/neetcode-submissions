class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        sList = list(s)
        sList.sort()
        tList = list(t)
        tList.sort()
        for i,j in zip(sList, tList):
            if i == j:
                continue
            else:
                return False

        return True
