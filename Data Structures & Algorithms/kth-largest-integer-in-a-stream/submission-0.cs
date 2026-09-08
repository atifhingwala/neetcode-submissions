public class KthLargest {
    private List<int> numsL;
    private int K;
    
    public KthLargest(int k, int[] nums) {
        numsL = nums.ToList();
        K = k;
    }
    
    public int Add(int val) {
        numsL.Add(val);
        numsL = numsL.OrderByDescending(x => x).ToList();

        return numsL[K-1];
    }
}
