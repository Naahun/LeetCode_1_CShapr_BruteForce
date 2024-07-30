using System.Collections.Immutable;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExample1()
        {
            Solution solution = new Solution();
            int[] inputArray = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = new int[] { 0, 1 };
            int[] returnValue = solution.TwoSum(inputArray, target);
            Array.Sort(returnValue);
            Assert.IsTrue(returnValue.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestExample2()
        {
            Solution solution = new Solution();
            int[] inputArray = { 3, 2, 4 };
            int target = 6;
            int[] expected = new int[] { 1, 2 };
            int[] returnValue = solution.TwoSum(inputArray, target);
            Array.Sort(returnValue);
            Assert.IsTrue(returnValue.SequenceEqual(expected));
        }
        [TestMethod]
        public void TestExample3()
        {
            Solution solution = new Solution();
            int[] inputArray = { 3, 3 };
            int target = 6;
            int[] expected = new int[] { 0, 1 };
            int[] returnValue = solution.TwoSum(inputArray, target);
            Array.Sort(returnValue);
            Assert.IsTrue(returnValue.SequenceEqual(expected));
        }
        [TestMethod]
        public void TestElementsOnBorder()
        {
            Solution solution = new Solution();
            int[] array = { 1, 2, 6 };
            int[] expected = new int[] { 0, 2 };
            int[] returnValue = solution.TwoSum(array, 7);
            Array.Sort(returnValue);
            Assert.IsTrue(returnValue.SequenceEqual( expected));
        }
        [TestMethod]
        public void TestNullArrayInput_ShouldThrowArgumentNullException()
        {
            Solution solution = new Solution();
            int[] array = null;
            int target = 404;
            Assert.ThrowsException<System.ArgumentNullException>(() => solution.TwoSum(array, target));
        }

        [TestMethod]
        public void TestNullArrayInput_ShouldThrowArgumentException_1()
        {
            Solution solution = new Solution();
            int[] array = { };
            int target = 404;
            Assert.ThrowsException<System.ArgumentException>(() => solution.TwoSum(array, target));
        }

        [TestMethod]
        public void TestNullArrayInput_ShouldThrowArgumentException_2()
        {
            Solution solution = new Solution();
            int[] array = { 1 };
            int target = 404;
            Assert.ThrowsException<System.ArgumentException>(() => solution.TwoSum(array, target));
        }
    }
}