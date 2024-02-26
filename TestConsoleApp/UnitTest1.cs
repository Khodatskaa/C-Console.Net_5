using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace TestConsoleApp
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestGetProductInRange()
        {
            int start = 2;
            int end = 5;
            long expectedResult = 2 * 3 * 4 * 5;

            long result = Program.GetProductInRange(start, end);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestIsFibonacci()
        {
            int fibonacciNumber = 21;
            int nonFibonacciNumber = 6;

            Assert.IsTrue(Program.IsFibonacci(fibonacciNumber));
            Assert.IsFalse(Program.IsFibonacci(nonFibonacciNumber));
        }

        [TestMethod]
        public void TestCustomSortAscending()
        {
            int[] array = { 5, 2, 8, 1, 7 };
            int[] expectedArray = { 1, 2, 5, 7, 8 };

            int[] result = Program.CustomSort(array, "Ascending");

            CollectionAssert.AreEqual(expectedArray, result);
        }

        [TestMethod]
        public void TestCustomSortDescending()
        {
            int[] array = { 5, 2, 8, 1, 7 };
            int[] expectedArray = { 8, 7, 5, 2, 1 };

            int[] result = Program.CustomSort(array, "Descending");

            CollectionAssert.AreEqual(expectedArray, result);
        }
    }
}
