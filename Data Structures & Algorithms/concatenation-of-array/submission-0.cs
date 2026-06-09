public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length * 2];
        ans = nums.Concat(nums).ToArray();

        return ans;
    }
}