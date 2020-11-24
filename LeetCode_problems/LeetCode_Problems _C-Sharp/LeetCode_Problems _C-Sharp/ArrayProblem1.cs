using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Problems__C_Sharp
{
    public class ArrayProblem1
    {
        public static int[] RunningSum(int[] nums)
        {
            List<int> sumsList = new List<int>();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    sumsList.Add(nums[i]);
                }
                else
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (j <= i)
                        {
                            sum = sum + nums[j];

                            if (j == i)
                            {
                                sumsList.Add(sum);
                                sum = 0;
                            }
                        }
                    }
                }
            }
            return sumsList.ToArray();
        }

        public static int[] RunningSum2(int[] nums)
        {
            List<int> sumsList = new List<int>();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    sumsList.Add(nums[i]);
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        sum = sum + nums[j];

                        if (j == i)
                        {
                            sumsList.Add(sum);
                            sum = 0;
                        }
                    }
                }
            }
            return sumsList.ToArray();
        }
    }
}
