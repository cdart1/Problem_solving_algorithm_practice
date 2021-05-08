using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunningSum1dArray;
using AreTwoStringArraysEquivalentProblem;
using _704BinarySearch;

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
            int[] testResult4 = RunningSumProblem.RunningSum2(test1);
            int[] testResult5 = RunningSumProblem.RunningSum2(test2);
            int[] testResult6 = RunningSumProblem.RunningSum2(test3);

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
            for (int i = 0; i < test1.Length; i++)
            {
                Assert.AreEqual(expected1[i], testResult4[i]);
            }
            for (int i = 0; i < test2.Length; i++)
            {
                Assert.AreEqual(expected2[i], testResult5[i]);
            }
            for (int i = 0; i < test3.Length; i++)
            {
                Assert.AreEqual(expected3[i], testResult6[i]);
            }
        }

        [TestMethod]
        public void ArrayStringsAreEqualTest()
        {
            string[] word1Array1 = { "ab", "c" };
            string[] word1Array2 = { "a", "bc" };
            string[] word2Array1 = { "a", "cb" };
            string[] word2Array2 = { "ab", "c" };
            string[] word3Array1 = { "abc", "d", "defg" };
            string[] word3Array2 = { "abcddefg" };


            bool result1 = AreTwoStringArraysEquivalent.ArrayStringsAreEqual(word1Array1, word1Array2);
            bool result2 = AreTwoStringArraysEquivalent.ArrayStringsAreEqual(word2Array1, word2Array2);
            bool result3 = AreTwoStringArraysEquivalent.ArrayStringsAreEqual(word3Array1, word3Array2);


            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }

        [TestMethod]
        public void BinarySearchTest()
        {
            int[] nums1 = { 2, 4, 6, 7, 8};
            int[] nums2 = { 100, 200, 300, 400};
            int[] nums3 = { -1, 0, 99};

            int target1 = 8;
            int target2 = 100;
            int target3 = 99;
            int target4 = 9;

            int result1 = BinarySearchProgram.BinarySearch(nums1, target1);
            int result2 = BinarySearchProgram.BinarySearch(nums1, target4);
            int result3 = BinarySearchProgram.BinarySearch(nums2, target2);
            int result4 = BinarySearchProgram.BinarySearch(nums2, target4);
            int result5 = BinarySearchProgram.BinarySearch(nums3, target3);
            int result6 = BinarySearchProgram.BinarySearch(nums3, target4);

            int expected1 = 4;
            int expected2 = -1;
            int expected3 = 0;
            int expected4 = -1;
            int expected5 = 2;
            int expected6 = -1;

            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, result3);
            Assert.AreEqual(expected4, result4);
            Assert.AreEqual(expected5, result5);
            Assert.AreEqual(expected6, result6);
        }
    }
}
