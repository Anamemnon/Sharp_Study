// 589. N-ary Tree Preorder Traversal
// https://leetcode.com/problems/n-ary-tree-preorder-traversal/?envType=study-plan&id=level-1
//
// Given the root of an n-ary tree, return the preorder traversal of its nodes' values.
// Nary - Tree input serialization is represented in their level order traversal.
// Each group of children is separated by the null value (See examples)

Console.WriteLine("Hello, World!");

public class Node
{
    public int val;
    public IList<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}

public class Solution
{
    public IList<int> Preorder(Node root)
    {
        IList<int> result = new List<int>();
        Helper(root, ref result);
        return result;

        void Helper(Node node, ref IList<int> result)
        {
            if (node is null) return;
            result.Add(node.val);

            foreach(Node child in node.children)
            {
                Helper(child, ref result);
            }
        }
    }
}