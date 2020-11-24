using System;
using System.Collections.Generic;
using System.Text;

namespace TotalThreeHighestNums
{
    class Add3HighestNumsProblem
    {
        /// <summary>
        /// NOTE: This solution is time complexity: O(n)
        /// Removes the highest number in a list, and adds it to sum (happens three times, each time with an updated list).
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns>
        /// Returns the sum of the three largest numbers in the given array.
        /// </returns>
        public static int Add3Highest(int[] inputArray)
        {
            int sum = 0;
            List<int> numList = new List<int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                numList.Add(inputArray[i]);
            }
            List<int> firstHighest = FindHighest(numList);
            numList.RemoveAt(firstHighest[1]);
            sum = sum + firstHighest[0];
            List<int> secHighest = FindHighest(numList);
            numList.RemoveAt(secHighest[1]);
            sum = sum + secHighest[0];
            List<int> thrHighest = FindHighest(numList);
            numList.RemoveAt(thrHighest[1]);
            sum = sum + thrHighest[0];

            return sum;
        }
       
        /// <summary>
        /// Finds the highest number in a given list.
        /// </summary>
        /// <param name="numList"></param>
        /// <returns>
        /// Returns a list of two elements, the first element being the highest number found in the given list and the second element 
        /// being the index of that highest number from the given list.
        /// </returns>
        public static List<int> FindHighest(List<int> numList)
        {
            List<int> highestAndPosition = new List<int>();
            int highest = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] > highest)
                {
                    highest = numList[i];
                    var newHighestAndPosition = new List<int>();
                    newHighestAndPosition.Add(highest);
                    newHighestAndPosition.Add(i);
                    highestAndPosition = newHighestAndPosition;
                }
            }
            return highestAndPosition;
        }

        /// <summary>
        /// NOTE: This solution is time complexity: O(n)^2
        /// Using bubble sort to put array in ascending order, then adding the last three numbers. 
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns>
        /// Returns the sum of the three largest numbers in the given array.
        /// </returns>
        public static int Add3Highest2(int[] inputArray)
        {
            int[] sortedArray = BubbleSort(inputArray);
            return sortedArray[sortedArray.Length - 1] + sortedArray[sortedArray.Length - 2] + sortedArray[sortedArray.Length - 3];
        }

        /// <summary>
        /// Reorders array in ascending order.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns>
        /// Returns a sorted array.
        /// </returns>
        public static int[] BubbleSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int k = 0; k < inputArray.Length - 1; k++)
                {
                    if (inputArray[k] > inputArray[k + 1])
                    {
                        int temp = inputArray[k];
                        inputArray[k] = inputArray[k + 1];
                        inputArray[k + 1] = temp;
                    }
                }
            }
            return inputArray;
        }

    }
}
