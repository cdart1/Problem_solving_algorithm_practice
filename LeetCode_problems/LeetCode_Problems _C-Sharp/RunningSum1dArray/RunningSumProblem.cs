using System;
using System.Collections.Generic;
using System.Text;

namespace RunningSum1dArray
{
    /*
        Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
        Return the running sum of nums. 

        Example 1:

        Input: nums = [1,2,3,4]
        Output: [1,3,6,10]
        Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

        Example 2:

        Input: nums = [1,1,1,1,1]
        Output: [1,2,3,4,5]
        Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
    */

    public class RunningSumProblem
    {
        /// <summary>
        /// When iterating through 'nums', we use position 'j' to iterate backwards, adding the value of nums[j] to 'sum' each time until j reaches 0, 
        /// then assign the current sum to numArray[i].
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>
        /// An array with the running sums of the input array.
        /// </returns>
        public static int[] RunningSum(int[] nums)
        {
            int[] numsArray = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    numsArray[i] = nums[i];
                }
                if (i > 0)
                {
                    for (int j = i; j >= 0; j--)
                    {
                        sum = sum + nums[j];
                    }
                    numsArray[i] = sum;
                    sum = 0;
                }
            }
            return numsArray;
        }
    }
}
