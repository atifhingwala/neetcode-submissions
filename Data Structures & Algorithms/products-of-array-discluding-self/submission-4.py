class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        product = 1
        zeros = 0
        zeroIndex = []
        result = []
        for n in nums:
            if n == 0:
                zeros = zeros + 1
                zeroIndex.append(nums.index(n))
            product *= n
        
        if zeros > 1:
            return [0] * len(nums)
        elif zeros == 0:
            for n in nums:
                result.append(int(product/n))
            return result
        else:
            result = [0] * len(nums)
            product = 1
            for i,n in enumerate(nums):
                if i == zeroIndex[0]:
                    continue
                product *= n
            result[zeroIndex[0]] = product
        
        return result
                


