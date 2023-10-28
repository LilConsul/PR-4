using Xunit;
using PR_4;

namespace ArrayTest {
    public class Tests {
        [Theory]
        [InlineData(new int[]{1, 2, 3, 4}, new int[]{1, 2, 3, 4})]
        [InlineData(new int[]{-1, -2, 3, 4}, new int[]{3, 4})]
        [InlineData(new int[]{1, -2, 3, 4}, new int[]{1, 3, 4})]
        [InlineData(new int[]{1, -2, 3, -4}, new int[]{1, 3, -4})]
        public void BasicTest(int[] input, int[] expected) {
            var arr = new MyArray(input);
            var actual = arr.Calculate();
            Assert.Equal(expected, actual);
        }
    }
}