namespace TestConsoleApp
{
    [TestClass]
    public class ProgramTests
    {
        //Test 1
        [TestMethod]
        public void TestProductInRange()
        {
            Assert.AreEqual(120, Model.ProductInRange(1, 5));
        }

        //Test 2
        [TestMethod]
        public void TestIsFibonacci()
        {
            Assert.IsTrue(Model.IsFibonacci(13));
        }

        //Test 3
        [TestMethod]
        public void TestSortArray()
        {
            int[] arrayToSort = { 5, 2, 8, 1, 3 };
            Model.SortArray(arrayToSort, Model.SortOrder.Ascending);
            Assert.AreEqual("1, 2, 3, 5, 8", string.Join(", ", arrayToSort));
        }

        //Test 4
        [TestMethod]
        public void TestCity()
        {
            Model.City city = new Model.City();
            city.InputData();
            city.OutputData();
        }

        //Test 5
        [TestMethod]
        public void TestEmployee()
        {
            Model.Employee employee = new Model.Employee();
            employee.InputData();
            employee.OutputData();
        }

        //Test 6
        [TestMethod]
        public void TestAircraft()
        {
            Model.Aircraft aircraft = new Model.Aircraft();
            aircraft.InputData();
            aircraft.OutputData();
        }

        //Test 7
        [TestMethod]
        public void TestMatrix()
        {
            Model.Matrix matrix = new Model.Matrix();
            matrix.InputData();
            matrix.OutputData();
            Assert.AreEqual(9, matrix.GetMax());
            Assert.AreEqual(1, matrix.GetMin());
        }
    }
}
