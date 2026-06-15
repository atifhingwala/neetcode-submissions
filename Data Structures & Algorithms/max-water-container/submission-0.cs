public class Solution {
    public int MaxArea(int[] heights) {
        int heiLen = heights.Length;
        int max = 0;
        for (int i = 0; i < heiLen; i++)
        {
            for (int j = i+1; j < heiLen; j++)
            {
                int maxHei = Math.Min(heights[i], heights[j]);
                max = Math.Max(maxHei * (j-i), max);
            }
        }

        return max;
    }
}
