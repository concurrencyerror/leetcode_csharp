namespace leetcode.leetcode;

public class Solution2236
{
    public bool CheckTree(TreeNode root)
    {
        return root.left.val + root.right.val == root.val;
    }
}