using System;

namespace EvensOddsArray
{
    class Program
    {
        //  Determine how many even and how many odd numbers are in a given array of integers.
        static void Main(string[] args)
        {
            int[] nums = { 4, 7, 6, 2, 8 };
            int[] nums2 = { 3, 7, 5, 1, 9 };

            EvensOddsArrayProblem.EvensOdds(nums);
            Console.WriteLine("===================");
            EvensOddsArrayProblem.EvensOdds(nums2);
        }
    }
}
