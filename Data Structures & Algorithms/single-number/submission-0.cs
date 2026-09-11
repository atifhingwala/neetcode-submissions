public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int n in nums)
        {
            if (dict.ContainsKey(n))
            {
                dict[n]++;
            }
            else
            {
                dict[n] = 1;
            }
        }

        return dict.FirstOrDefault(x => x.Value == 1).Key;
    }
}
