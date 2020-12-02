﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AllMyAlgorithms
{
    /*
     * Given an array of positive integers a, your task is to calculate the sum of every possible a[i] ∘ a[j], where a[i] ∘ a[j] is the concatenation of the string representations of a[i] and a[j] respectively.
        
        Example
        For a = [10, 2], the output should be concatenationsSum(a) = 1344.
        a[0] ∘ a[0] = 10 ∘ 10 = 1010,
        a[0] ∘ a[1] = 10 ∘ 2 = 102,
        a[1] ∘ a[0] = 2 ∘ 10 = 210,
        a[1] ∘ a[1] = 2 ∘ 2 = 22.
        So the sum is equal to 1010 + 102 + 210 + 22 = 1344.
        
        For a = [8], the output should be concatenationsSum(a) = 88.
        There is only one number in a, and a[0] ∘ a[0] = 8 ∘ 8 = 88, so the answer is 88.
        
        For a = [1, 2, 3], the output should be concatenationsSum(a) = 198.
        a[0] ∘ a[0] = 1 ∘ 1 = 11,
        a[0] ∘ a[1] = 1 ∘ 2 = 12,
        a[0] ∘ a[2] = 1 ∘ 3 = 13,
        a[1] ∘ a[0] = 2 ∘ 1 = 21,
        a[1] ∘ a[1] = 2 ∘ 2 = 22,
        a[1] ∘ a[2] = 2 ∘ 3 = 23,
        a[2] ∘ a[0] = 3 ∘ 1 = 31,
        a[2] ∘ a[1] = 3 ∘ 2 = 32,
        a[2] ∘ a[2] = 3 ∘ 3 = 33.
        The total result is 11 + 12 + 13 + 21 + 22 + 23 + 31 + 32 + 33 = 198.
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer a
        A non-empty array of positive integers.
        
        Guaranteed constraints:
        1 ≤ a.length ≤ 105,
        1 ≤ a[i] ≤ 106.
        [output] integer64
        The sum of all a[i] ∘ a[j]s. It's guaranteed that the answer is less than 253.

    */
    public class ConcatenateSumClass
    {
        /// <summary>
        /// Takes in an int array, converts it to a List of strings and concatenates every possible
        /// combination of the strings, then converts it to an int to add the sum.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>
        /// Outputs the sum of the combination of numbers given.
        /// </returns>
        public static int ConcatenateSum(int[] array)
        {
            var strList = new List<string>();
            foreach (var i in array)
            {
                strList.Add(i.ToString());
            }

            if (strList.Count == 1)
            {
                string c = strList[0] + strList[0];
                int c2 = Convert.ToInt32(c);
                return c2;
            }

            else if(strList.Count < 1)
            {
                return 0;
            }

            var intList = new List<int>();
            for (int i = 0; i < strList.Count; i++)
            {
                for (int j = 0; j < strList.Count; j++)
                {
                    string num = strList[i] + strList[j];
                    int newNum = Convert.ToInt32(num);
                    intList.Add(newNum);
                }
            }
            int sum = 0;
            for (int i = 0; i < intList.Count; i++)
            {
                sum += intList[i];
            }
            return sum;
        }
    }
}
