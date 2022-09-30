/* 1379. Find a Corresponding Node of a Binary Tree in a Clone of That Tree
 * 
 * Given two binary trees original and cloned and given a reference to a node target 
 * in the original tree.
 * The cloned tree is a copy of the original tree.
 * 
 * Return a reference to the same node in the cloned tree.
 * Note that you are not allowed to change any of the two trees or 
 * the target node and the answer must be a reference to a node in the cloned tree.
 */

//Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}


public class Solution
{
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
    {
        if (original == null) return original;

        var q = new Queue<TreeNode>(new[] { cloned } );

        while (q.Count > 0)
        {
            var currentNode = q.Dequeue();

            if (currentNode is not null)
            {
                if (currentNode.val == target.val) return currentNode;
                else
                {
                    q.Enqueue(currentNode.left);
                    q.Enqueue(currentNode.right);
                }
            }
        }

        return cloned;
    }
}