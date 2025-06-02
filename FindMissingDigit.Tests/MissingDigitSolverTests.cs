namespace FindMissingDigit.Tests
{
    public class MissingDigitSolverTests
    {
        [Theory(DisplayName = "Finds the Correct Digit with Valid Expressions")]
        [InlineData("1? + 23 = 35", 2)]
        [InlineData("4 * ? = 28", 7)]
        [InlineData("?3 - 11 = 22", 3)]
        [InlineData("150 / 3 = 5?", 0)]
        [InlineData("1? + 2 = 50", -1)]
        public void FindsCorrectDigit(string expression, int expected)
        {
            int result = MissingDigitSolver.FindMissingDigit(expression);
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Returns -1 When Expression is Invalid")]
        public void ReturnsNegativeOne_WhenExpressionIsInvalid()
        {
            string expression = "1a5 + 30 = 3?";

            int result = MissingDigitSolver.FindMissingDigit(expression);
            Assert.Equal(-1, result);
        }
    }
}
