/* 111. Minimum Depth of Binary Tree
 * 
 * Given a binary tree, find its minimum depth. 
 * The minimum depth is the number of nodes along the shortest path 
 * from the root node down to the nearest leaf node.
 */
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int MinDepth(TreeNode root) => root switch
    {
        null => 0,
        {left: null , right: null} => 1,
        {left: null, } => 1 + MinDepth(root.right),
        {right: null} => 1 + MinDepth(root.left),
        { } => 1 + Math.Min(MinDepth(root.left), MinDepth(root.right))
    };
}