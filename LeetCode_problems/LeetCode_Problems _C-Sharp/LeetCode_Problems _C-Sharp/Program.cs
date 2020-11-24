using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_Problems__C_Sharp
{
    class Program
    {
        // Leetcode problem: https://leetcode.com/problems/running-sum-of-1d-array/
        static void Main(string[] args)
        {
            int[] nums = { 1,2,3,4 };

            int[] numbers = ArrayProblem1.RunningSum2(nums);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
