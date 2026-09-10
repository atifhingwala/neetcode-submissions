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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        TreeNode cur = root;

        while (cur != null)
        {
            if (Math.Min(p.val, q.val) > cur.val)
            {
                cur = cur.right;
            }
            else if (Math.Max(p.val, q.val) < cur.val)
            {
                cur = cur.left;
            }
            else
            {
                return cur;
            }
        }

        return null;
    }
}
