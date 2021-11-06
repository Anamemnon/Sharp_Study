public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        int[] counts = new int[101];

        for (int i = 0; i < nums.Length; i++)
        {
            counts[nums[i]]++;
        }

        return counts.Sum(x => x * (x - 1) / 2);
    }
}