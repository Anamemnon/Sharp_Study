#nullable disable
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

public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        TreeNode answer = null;
        
        if (nums == null || nums.Count() == 0){
            return answer;
        }
        int length = nums.Count();
        
        answer = new TreeNode(nums[length/2]);
        
        answer.left = SortedArrayToBST(nums.Take(length/2).ToArray());
        answer.right = SortedArrayToBST(nums.Skip(length/2 + 1).Take(length - (length/2 + 1)).ToArray());
        
        return answer;
    }
}