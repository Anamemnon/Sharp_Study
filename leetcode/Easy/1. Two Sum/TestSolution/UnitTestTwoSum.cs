using Xunit;
using Solution;

namespace TestSolution
{
    public class TestTwoSum
    {
        [Fact]
        public void Test1()
        {
            Solution.Solution solution = new();
            Assert.Equal(solution.TwoSum(new[] { 2, 7, 11, 15 }, 9), new [] {0,1});
        }

        [Fact]
        public void Test2()
        {
            Solution.Solution solution = new();
            Assert.Equal(solution.TwoSum(new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1}, 11), new[] { 5, 11 });
        }
    }
}