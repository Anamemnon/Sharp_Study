namespace Solution
{
    public static class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            IDictionary<int, int> result = new Dictionary<int, int>();

            foreach (var (item, index) in nums.Select((item, index) => (item, index)))
            {
                var key = target - item;
                if (result.ContainsKey(key))
                {
                    return new[] { result[key], index };
                }

                var isAdded = result.TryAdd(item, index);
                if (isAdded is false)
                {
                    result[item] = index;
                }
            }

            return new[] { -1, -1 };
        }
    }
}
