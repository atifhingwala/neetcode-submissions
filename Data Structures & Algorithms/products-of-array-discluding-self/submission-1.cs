public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int zeroCount = 0;
        foreach(var i in nums)
        {
            if (i != 0)
            {
                product = product * i;
            }
            else
            {
                zeroCount++;
            }
            
        }

        int[] output = new int[nums.Length];
        if (zeroCount > 1) return new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (zeroCount > 0)
            {
                output[i] = (nums[i] == 0) ? product : 0;
            }
            else
            {
                output[i] = product / nums[i];
            }
            
        }

        return output;
    }
}
