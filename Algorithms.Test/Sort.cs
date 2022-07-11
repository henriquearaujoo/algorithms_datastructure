namespace Algorithms.Test
{
    public class Sort
    {
        [Fact(DisplayName = "Should sort an integers array")]
        public void Test1()
        {
            var unsortedArray = new [] { 4, 2, 7, 20, 34, 5, -10, -34 };
            var sort = new Algorithms.Sort();
            var expected = new[] { -34, -10, 2, 4, 5, 7, 20, 34 };
            Assert.Equal(expected, sort.Execute(unsortedArray));
        }
    }
}