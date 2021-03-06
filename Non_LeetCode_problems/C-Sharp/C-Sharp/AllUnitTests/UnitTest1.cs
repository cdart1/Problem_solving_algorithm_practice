using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortedOrderArray;
using ConcatenateSumProblem;

namespace AllUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] input1 = { 1, 3, 5, 6, 4, 2 };
            int[] input2 = { 1, 4, 5, 6, 3 };

            bool result1 = SortedOrderArrayProblem.SortArrayAscending(input1);
            bool result2 = SortedOrderArrayProblem.SortArrayAscending(input2);
            bool method2Result1 = SortedOrderArrayProblem.SortArrayAscending2(input1);
            bool method2Result2 = SortedOrderArrayProblem.SortArrayAscending2(input2);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(method2Result1);
            Assert.IsFalse(method2Result2);
        }

        [TestMethod]
        public void ConcatenateSumProblemTest()
        {
            int[] input1 = { 10, 2 };
            int[] input2 = { 8 };
            int[] input3 = { 1, 2, 3 };

            int result1 = ConcatenateSumClass.ConcatenateSum(input1);
            int result2 = ConcatenateSumClass.ConcatenateSum(input2);
            int result3 = ConcatenateSumClass.ConcatenateSum(input3);

            Assert.AreEqual(1344, result1);
            Assert.AreEqual(88, result2);
            Assert.AreEqual(198, result3);
        }
    }
}
