class Solution:
    def findLucky(self, arr: List[int]) -> int:
        freq_arr = Counter(arr)
        freq_arr_list = freq_arr.most_common()
        for k, v in freq_arr_list:
            if k == v:
                return k
        
        return -1