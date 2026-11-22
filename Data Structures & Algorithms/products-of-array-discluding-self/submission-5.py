class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        res = []
        product = 1
        zeros = 0
        zeroIndex = 0
        for n in nums:
            if n == 0:
                zeros+=1
                zeroIndex = nums.index(n)
            else:
                product *= n
        
        if zeros>1:
            return [0]*len(nums)
        elif zeros == 1:
            res = [0]*len(nums)
            res[zeroIndex] = product
        else:
            for n in nums:
                res.append(product // n)

        return res
