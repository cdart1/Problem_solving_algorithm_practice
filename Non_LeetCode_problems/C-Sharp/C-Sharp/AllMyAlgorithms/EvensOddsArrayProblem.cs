using System;
using System.Collections.Generic;
using System.Text;

namespace AllMyAlgorithms
{
    public class EvensOddsArrayProblem
    {
        /// <summary>
        /// Checks if the remainder of each number in numArray is '0', then adds one to either evenCount or oddCount.
        /// </summary>
        /// <param name="numArray"></param>
        /// <param name="evenCount"></param>
        /// <param name="oddCount"></param>
        public static void EvensOdds(int[] numArray, out int evenCount, out int oddCount)
        {
            evenCount = 0;
            oddCount = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                int evenCheck = numArray[i] % 2;
                Console.WriteLine(evenCheck);
                if (evenCheck == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Evens: " + evenCount + " Odds: " + oddCount);
        }
    }
}
