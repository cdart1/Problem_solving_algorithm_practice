using System;
using System.Collections.Generic;
using System.Text;

namespace _704BinarySearch
{
    public class BinarySearchProgram
    {
        public static int BinarySearch(int[] nums, int target)
        {
            // Below we keep track of indicies.
            int mid;
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
