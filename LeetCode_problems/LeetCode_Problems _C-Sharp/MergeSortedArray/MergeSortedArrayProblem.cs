using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortedArray
{
    public class MergeSortedArrayProblem
    {
        /// <summary>
        /// Checks for value to be '0' at nums1[j] which will assign the current value at nums2[i] to the current position in nums1[j].
        /// Sorts merged array using BubbleSort method.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        /// <returns>
        /// One merged sorted array.
        /// </returns>
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m + n; j++)
                {
                    if (nums1[j] == 0)
                    {
                        nums1[j] = nums2[i];
                        // This break statement will stop the execution of the this nested loop
                        // and start executing the next line of code after the block (in this case 
                        //it goes back to the outer loop and increments 'i'.
                        break;
                    }
                }
            }
            int[] nums1Sorted = BubbleSort(nums1);
            return nums1Sorted;
        }

        public static int[] BubbleSort(int[] nums1)
        {
            int numVal = 0;
            for (int k = 0; k < nums1.Length - 1; k++)
            {
                for (int i = 0; i < nums1.Length - 1; i++)
                {
                    if (nums1[i] > nums1[i + 1])
                    {
                        numVal = nums1[i];
                        nums1[i] = nums1[i + 1];
                        nums1[i + 1] = numVal;
                    }
                }
            }
            return nums1;
        }
    }
}
