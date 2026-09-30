class Solution:
    def largestGoodInteger(self, num: str) -> str:
        res = ""
        maxVal = 0
        for i in range(len(num) - 2):
            if num[i] == num[i+1] == num[i+2]:
                tmp = num[i:i+3]
                if maxVal <= int(tmp):
                    maxVal = int(tmp)
                    res = tmp
        
        return res
