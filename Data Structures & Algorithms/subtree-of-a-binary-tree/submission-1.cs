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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null && subRoot == null) return true;
        if (root == null || subRoot == null) return false;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            if (node.val == subRoot.val)
            {
                if (IsSameTree(node, subRoot)) return true;
            }
            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);
        }

        return false;
    }

    private bool IsSameTree(TreeNode p, TreeNode q)
    {
        bool leftRes;
        bool rightRes;
        if (p!= null && q!= null && p.val == q.val)
        {
            leftRes = IsSameTree(p.left, q.left);
            rightRes = IsSameTree(p.right, q.right);
        }
        else if (p == null && q == null)
        {
            return true;
        }
        else
        {
            return false;
        }

        return leftRes && rightRes;       
    }
}
