/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // BFS
        Queue<(TreeNode, TreeNode)> queue = new Queue<(TreeNode, TreeNode)>();
        queue.Enqueue((p, q));
        while (queue.Count > 0)
        {
            var (node1, node2) = queue.Dequeue();
            if ((node1 != null && node2 != null) && node1.val == node2.val)
            {
                queue.Enqueue((node1.left, node2.left));
                queue.Enqueue((node1.right, node2.right));
            }
            else if (node1 == null && node2 == null)
            {
                continue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
