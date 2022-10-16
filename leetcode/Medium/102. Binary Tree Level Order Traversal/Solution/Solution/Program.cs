/* 102. Binary Tree Level Order Traversal
 * https://leetcode.com/problems/binary-tree-level-order-traversal/?envType=study-plan&id=level-1
 * 
 * Given the root of a binary tree, return the level order traversal of its nodes' values. 
 * (i.e., from left to right, level by level).
 */

//Definition for a binary tree node.
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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> list = new List<IList<int>>();

        if (root == null) return list;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            int count = queue.Count;
            List<int> row = new();

            for (int i = 0; i < count; i++)
            {
                TreeNode node = queue.Dequeue();
                row.Add(node.val);

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            list.Add(row);
        }

        return list;
    }
}