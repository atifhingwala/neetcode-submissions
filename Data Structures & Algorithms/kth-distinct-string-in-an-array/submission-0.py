class Solution:
    def kthDistinct(self, arr: List[str], k: int) -> str:
        arr_count = Counter(arr)
        count = 0
        for s in arr:
            if arr_count[s] == 1:
                count+=1
                if count == k:
                    return s
        
        return ""
