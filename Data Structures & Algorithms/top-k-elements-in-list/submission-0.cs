public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
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

        int[] arr = dict.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();

        return arr.Take(k).ToArray();
    }
}
