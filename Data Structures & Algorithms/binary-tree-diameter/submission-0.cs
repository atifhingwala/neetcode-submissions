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
    int res = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null) return 0;
        DFS(root);

        return res;
    }

    public int DFS(TreeNode node)
    {
        if (node == null) return 0;

        int leftHeight = DFS(node.left);
        int rightHeight = DFS(node.right);

        res = Math.Max(res, leftHeight + rightHeight);

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
