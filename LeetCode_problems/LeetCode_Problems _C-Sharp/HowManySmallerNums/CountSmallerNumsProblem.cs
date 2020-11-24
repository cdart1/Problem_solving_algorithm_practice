using System;
using System.Collections.Generic;
using System.Text;

namespace HowManySmallerNums
{
    class CountSmallerNumsProblem
    {
        public static List<int> CountSmallerNums(int[] nums)
        {
            int count = 0;
            List<int> countArray = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        count++;
                    }
                }
                countArray.Add(count);
                count = 0;
            }
            return countArray;
        }

        public static int[] CountSmallerNums2(int[] nums)
        {
            int count = 0;
            int[] countArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        count++;
                    }
                }
                countArray[i] = count;
                count = 0;
            }
            return countArray;
        }
    }
}
