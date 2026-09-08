public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        foreach (int s in stones)
        {
            queue.Enqueue(-s, -s);
        }

        while (queue.Count > 1)
        {
            int first = -1 * queue.Dequeue();
            int second = -1 * queue.Dequeue();
            int result = Math.Abs(first - second);
            queue.Enqueue(-result, -result);
        }

        return Math.Abs(queue.Peek());
    }
}
