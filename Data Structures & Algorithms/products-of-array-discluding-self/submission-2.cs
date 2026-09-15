public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int product = 1;
        int zeros = 0;
        foreach (int n in nums)
        {
            if (n != 0)
            {
                product = product * n;
            }
            else
            {
                zeros++;
            }
        }
        if (zeros > 1)
        {
            return new int[nums.Length];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (zeros > 0)
            {
                if (nums[i] == 0)
                {
                    result[i] = product;
                }
            }
            else
            {
                result[i] = product / nums[i];
            }
        }

        return result;
    }
}
