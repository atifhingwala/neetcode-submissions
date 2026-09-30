class Solution:
    def largestGoodInteger(self, num: str) -> str:
        unique = set(num)
        maxNum = -1
        for n in unique:
            if n + n + n in num:
                maxNum = max(maxNum, int(n+n+n))
        
        if maxNum == -1:
            return ""
        elif maxNum == 0:
            return "000"
        else:
            return str(maxNum)


