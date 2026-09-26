class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        minLen = 1000
        res = ""
        for s in strs:
            minLen = min(minLen, len(s))

        for i in range(minLen):
            fixChar = ''
            for j, s in enumerate(strs):
                if j == 0:
                    fixChar = s[i]
                else:
                    if s[i] == fixChar:
                        continue
                    else:
                        return res
            res = res + fixChar
        
        return res




