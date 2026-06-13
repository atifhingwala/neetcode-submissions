public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        nums = nums.Distinct().ToArray();
        int count = 0; int max = 0; int initial = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                initial = i;
                count = 1;
                if (max < count)
                {
                    max= count;
                }
                continue;
            }
            if (nums[i] - 1 == nums[i-1])
            {
                count++;
                if (max < count)
                {
                    max= count;
                }
            }
            else
            {
                initial = i;
                count = 1;
            }
            
        }

        return max;
    }
}
