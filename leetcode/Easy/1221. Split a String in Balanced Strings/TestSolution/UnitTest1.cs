namespace TestSolution
{
    public class UnitTest1
    {
        readonly Solution solution; 
        public UnitTest1()
        {
            solution = new Solution();
        }

        [Theory]
        [InlineData(4, "RLRRLLRLRL")]
        [InlineData(2, "RLRRRLLRLL")]
        [InlineData(1, "LLLLRRRR")]
        public void TestBalancedStringSplit(int expected, string testData)
        {
            Assert.Equal(expected, solution.BalancedStringSplit(testData));
        }
    }
}