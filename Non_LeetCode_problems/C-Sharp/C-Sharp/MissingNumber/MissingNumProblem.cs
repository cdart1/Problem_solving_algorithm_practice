using System;
using System.Collections.Generic;
using System.Text;

namespace MissingNumber
{
    class MissingNumProblem
    {
        /// <summary>
        /// Finds the missing number by checking if numbers 1 through 8 are contained in HashSet 'inputArraySet'. By adding each number in 'inputArray' 
        /// we populate the HashSet.
        /// <param name="inputArray"></param>
        /// <returns>
        /// Returns the missing number in an array.
        /// </returns>
        public static int MissingNum(int[] inputArray)
        {
            int highestNum = MaxNum(inputArray);
            int missingNum = 0;

            HashSet<int> inputArraySet = new HashSet<int>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArraySet.Add(inputArray[i]);
            }

            for (int i = 1; i <= highestNum; i++)
            {
                if (!inputArraySet.Contains(i))
                {
                    missingNum = i;
                }
            }
            return missingNum;
        }

        /// <summary>
        /// Finds the highest number by traversing through the array, comparing each number with the previously recorded highest number.
        /// </summary>
        /// <param name="numArray"></param>
        /// <returns>
        /// Returns the highest number in an array.
        /// </returns>
        private static int MaxNum(int[] numArray)
        {
            int highest = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] > highest)
                {
                    highest = numArray[i];
                }
            }
            return highest;
        }
    }
}
