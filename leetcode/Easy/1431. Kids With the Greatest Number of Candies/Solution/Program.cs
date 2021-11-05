public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies.Max();
        IList<bool> result = candies
            .Select(cand => cand + extraCandies >= max)
            .ToList<bool>();
        return result;
    }
}