namespace TestConsoleApp
{
    [TestClass]
    public class programTest
    {
        [TestMethod]
        public void MapSquare_ShouldReturnCorrectSquare()
        {
            string result = Program.MapSquare(3, '*');
            string expected = "* * *\n* * *\n* * *\n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_ShouldReturnTrueForPalindrome()
        {
            bool result = Program.IsPalindrome(1221);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_ShouldReturnFalseForNonPalindrome()
        {
            bool result = Program.IsPalindrome(7854);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FilterArray_ShouldReturnFilteredArray()
        {
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };
            int[] resultArray = Program.FilterArray(originalArray, filterArray);
            int[] expectedArray = { 1, 2, -1 };
            Assert.AreEqual(expectedArray, resultArray);
        }

        [TestMethod]
        public void Website_OutputData_ShouldOutputCorrectString()
        {
            Website website = new Website();
            website.InputData();
            Assert.That(() => website.OutputData(), Is.EqualTo("Site Name: ..., Path: ..., Description: ..., IP Address: ..."));
        }

        [TestMethod]
        public void Journal_OutputData_ShouldOutputCorrectString()
        {
            Journal journal = new Journal();
            journal.InputData();
            Assert.That(() => journal.OutputData(), Is.EqualTo("Journal Name: ..., Year of Foundation: ..., Description: ...\nContact Phone Number: ..., Email: ..."));
        }

        [TestMethod]
        public void Store_OutputData_ShouldOutputCorrectString()
        {
            Store store = new Store();
            store.InputData();
            Assert.That(() => store.OutputData(), Is.EqualTo("Store Name: ..., Address: ..., Profile Description: ...\nContact Phone Number: ..., Email: ..."));
        }
    }
}
