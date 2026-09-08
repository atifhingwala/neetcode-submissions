public class KthLargest {
    private PriorityQueue<int,int> queue;
    private int K;

    public KthLargest(int k, int[] nums) {
        K=k;
        queue = new PriorityQueue<int,int>();
        nums = nums.OrderByDescending(x => x).ToArray();
        foreach (int n in nums)
        {
            queue.Enqueue(n, n);
            if (queue.Count > K)
            {
                queue.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        queue.Enqueue(val,val);
        if (queue.Count > K)
        {
            queue.Dequeue();
        }

        return queue.Peek();
    }
}
