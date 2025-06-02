namespace FindMissingDigit.Tests
{
    public class MissingDigitSolverTests
    {
        [Theory]
        [InlineData("1? + 23 = 35", 2)]
        [InlineData("4 * ? = 28", 7)]
        [InlineData("?3 - 11 = 22", 3)]
        [InlineData("1? + 2 = 50", -1)]  // No missing digit
        public void FindsCorrectDigit(string expression, int expected)
        {
            int result = MissingDigitSolver.FindMissingDigit(expression);
            Assert.Equal(expected, result);
        }
    }
}
