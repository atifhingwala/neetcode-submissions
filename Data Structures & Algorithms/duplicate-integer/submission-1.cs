public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> h = new HashSet<int>(nums);
        if (h.Count() == nums.Count())
        {
            return false;
        }

        return true;
    }
}