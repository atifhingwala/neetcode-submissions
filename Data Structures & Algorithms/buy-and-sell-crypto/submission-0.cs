public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int i = 0; int j = i+1;
        while (j < prices.Length)
        {
            if (prices[i] < prices[j])
            {
                maxProfit = Math.Max(maxProfit, (prices[j] - prices[i]));
                j++;
            }
            else
            {
                i = j;
                j++;
            }
        }

        return maxProfit;
    }
}
