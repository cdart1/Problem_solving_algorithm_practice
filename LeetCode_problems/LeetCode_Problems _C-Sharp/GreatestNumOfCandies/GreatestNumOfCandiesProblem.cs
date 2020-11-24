using System;
using System.Collections.Generic;
using System.Text;

namespace GreatestNumOfCandies
{
    /* Steps:
     * 1. Find the greatest number in the array 'candies'.
     * 2. If we add three more candies to each kid's current number of candies,
     *  would it be 5 or greater --> T or F.
     */
    class GreatestNumOfCandiesProblem
    {
        public static int FindHighest(int[] candies)
        {
            int highest = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > highest)
                {
                    highest = candies[i];
                }
            }
            return highest;
        }

        public static void GreatestNumOfCandies(int[] candies, int extraCandies)
        {
            int highest = FindHighest(candies);
            bool hasGreatest = false;
            foreach (int i in candies)
            {
                if (i + extraCandies >= highest)
                {
                    hasGreatest = true;
                    Console.Write(hasGreatest);
                }
                else 
                {
                    hasGreatest = false;
                    Console.Write(hasGreatest);
                }
            }
        }
    }
}
