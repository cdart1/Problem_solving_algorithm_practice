using System;

namespace _704BinarySearch
{
    /*
     * Given an array of integers nums which is sorted in ascending order, and an integer target, 
     * write a function to search target in nums. If target exists, then return its index. 
     * Otherwise, return -1.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 2;
            BinarySearchProgram.BinarySearch(nums, target);
        }
    }
}
