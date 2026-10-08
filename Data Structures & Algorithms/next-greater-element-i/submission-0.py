class Solution:
    def nextGreaterElement(self, nums1: List[int], nums2: List[int]) -> List[int]:
        res = []
        for n in nums1:
            if n in nums2:
                ind = nums2.index(n)
                ele = -1
                for j in range(ind, len(nums2)):
                    if nums2[j] > n and ele == -1:
                        res.append(nums2[j])
                        ele = nums2[j]
                if ele == -1:
                    res.append(-1)
        
        return res