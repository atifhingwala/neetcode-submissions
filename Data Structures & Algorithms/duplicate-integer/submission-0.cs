public class Solution {
    public bool hasDuplicate(int[] nums) {
        var nums1 = nums.Distinct().ToArray();
        if (nums.Length != nums1.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}