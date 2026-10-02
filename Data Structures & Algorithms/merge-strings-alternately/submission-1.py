class Solution:
    def mergeAlternately(self, word1: str, word2: str) -> str:
        count = 0
        res = ""
        n1, n2 = len(word1), len(word2)
        maxN = max(n1, n2)

        for i in range(maxN):
            if word1:
                res+= word1[0]
                word1 = word1[1:]
            if word2:
                res+= word2[0]
                word2 = word2[1:]

        
        return res





