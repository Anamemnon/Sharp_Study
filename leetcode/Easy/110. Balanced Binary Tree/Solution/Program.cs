Console.WriteLine("asd");

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
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;

        return Math.Abs(Height(root.left) - Height(root.right)) <= 1 
            && IsBalanced(root.left) 
            && IsBalanced(root.right);
    }

    private static int Height(TreeNode root)
    {
        if (root is null) return 0;

        return 1 + Math.Max(Height(root.left), Height(root.right));
    }
}