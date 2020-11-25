using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunningSum1dArray;

namespace AllUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Unit test that checks for equality between expected output and actual output.
        /// </summary>
        [TestMethod]
        public void RunningSumTest()
        {
            int[] test1 = { 1, 2, 3, 4 };
            int[] test2 = { 1, 1, 1, 1, 1 };
            int[] test3 = { 3, 1, 2, 10, 1 };

            int[] testResult1 = RunningSumProblem.RunningSum(test1);
            int[] testResult2 = RunningSumProblem.RunningSum(test2);
            int[] testResult3 = RunningSumProblem.RunningSum(test3);

            int[] expected1 = { 1, 3, 6, 10 };
            int[] expected2 = { 1, 2, 3, 4, 5 };
            int[] expected3 = { 3, 4, 6, 16, 17 };

            for (int i = 0; i < test1.Length; i++)
            {
                Assert.AreEqual(expected1[i], testResult1[i]);
            }
            for (int i = 0; i < test2.Length; i++)
            {
                Assert.AreEqual(expected2[i], testResult2[i]);
            }
            for (int i = 0; i < test3.Length; i++)
            {
                Assert.AreEqual(expected3[i], testResult3[i]);
            }
        }
    }
}
