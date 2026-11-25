class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        maxProfit = 0 
        l, r = 0, 1
        p = len(prices)
        while (r < p):
            if prices[l] < prices[r]:
                maxProfit = max(maxProfit, prices[r] - prices[l])
            else:
                l=r
            r+=1
        
        return maxProfit
            
            

