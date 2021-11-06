public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var setJewels = new HashSet<char>(jewels);
        int result = 0;

        foreach (char jewel in stones)
        {
            if (setJewels.Contains(jewel)) result++;
        }

        return result;
    }
}