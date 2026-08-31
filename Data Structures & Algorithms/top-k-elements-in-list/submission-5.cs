public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> frequency = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (frequency.TryGetValue(nums[i], out int val))
            {
                frequency[nums[i]]++;
            }
            else
            {
                frequency[nums[i]] = 1;
            }
        }

        int[] arr = frequency.OrderByDescending(x=>x.Value).Select(x=>x.Key).ToArray();

        return arr.Take(k).ToArray();
    }
}
