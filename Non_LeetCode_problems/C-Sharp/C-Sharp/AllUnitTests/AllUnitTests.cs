using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortedOrderArray;
using AllMyAlgorithms;
using System.Collections.Generic;

namespace AllUnitTests
{
    [TestClass]
    public class AllUnitTests
    {
        [TestMethod]
        public void SortArrayAscendingTest()
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

        [TestMethod]
        public void KVPToStringProblemTest()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                {"a", 1 },
                {"b", 2 },
                {"c", 3 },
            };

            string outputString = KVPToStringProblem.KVPToString(dictionary);
            string outputString2 = KVPToStringProblem.KVPToString2(dictionary);

            // Reminder: Remove space after 'c3'
            Assert.AreEqual("a1 b2 c3 ", outputString);
            Assert.AreEqual("a1b2c3", outputString2);
        }

        [TestMethod]
        public void CheckSumTest()
        {
            int input1 = 1;
            int input2 = 10;
            int input3 = 12;
            int input4 = 6;
            int input5 = 5;
            int input6 = 5;

            string result1 = CheckSumProblem.CheckSum(input1, input2);
            string result2 = CheckSumProblem.CheckSum(input3, input4);
            string result3 = CheckSumProblem.CheckSum(input5, input6);
            string result4 = CheckSumProblem.CheckSum2(input1, input2);
            string result5 = CheckSumProblem.CheckSum2(input3, input4);
            string result6 = CheckSumProblem.CheckSum2(input5, input6);

            Assert.AreEqual("true", result1);
            Assert.AreEqual("false", result2);
            Assert.AreEqual("-1", result3);
            Assert.AreEqual("true", result4);
            Assert.AreEqual("false", result5);
            Assert.AreEqual("-1", result6);
        }

        [TestMethod]
        public void MakeDictionaryTest()
        {
            // Add a for loop to compare keys and values of the expected and actual to complete the test.

            string[] input1 = { "a", "b", "c", "d" };
            int[] input2 = { 1, 2, 3, 4 };

            Dictionary<string, int> result1 = MakeDictionaryProblem.MakeDict(input1, input2);
            Dictionary<string, int> result2 = MakeDictionaryProblem.MakeDict2(input1, input2);

            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                {"a", 1 },
                {"b", 2 },
                {"c", 3 },
                {"d", 4 },
            };

            //Assert.AreEqual(dictionary, result1);
            //Assert.AreEqual(dictionary, result2);
        }

        [TestMethod]
        public void EvensOddsTest()
        {
            // Using out parameters since the method does not return anything.
            int[] input1 = { 4, 7, 6, 2, 8 };
            int[] input2 = { 3, 7, 5, 1, 9 };

            EvensOddsArrayProblem.EvensOdds(input1, out int result1Even, out int result1Odd);
            EvensOddsArrayProblem.EvensOdds(input2, out int result2Even, out int result2Odd);

            Assert.AreEqual(4, result1Even);
            Assert.AreEqual(1, result1Odd);
            Assert.AreEqual(0, result2Even);
            Assert.AreEqual(5, result2Odd);
        }
    }
}
