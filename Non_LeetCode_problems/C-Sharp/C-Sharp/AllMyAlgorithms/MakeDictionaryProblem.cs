using System;
using System.Collections.Generic;
using System.Text;

namespace AllMyAlgorithms
{
    public class MakeDictionaryProblem
    {
        /// <summary>
        /// Using a for loop, add each string and int respectively, to the dictionary, when variables 'j' and 'i' are equal.
        /// Both strArray and intArray are equivelent in length.
        /// </summary>
        /// <param name="strArray"></param>
        /// <param name="numArray"></param>
        /// <returns>
        /// A dictionary made of strings and ints, Keys and Values, respectively.
        /// </returns>
        public static Dictionary<string, int> MakeDict(string[] strArray, int[] numArray)
        {
            var arrayDict = new Dictionary<string, int>();
            int j = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (j == i)
                {
                    arrayDict.Add(strArray[i], numArray[j]);
                    j++;
                }
            }
            return arrayDict;
        }

        /// <summary>
        /// Using a for loop, add each string and int respectively to the dictionary, while 'i' is less than the length of the array.
        /// </summary>
        /// <param name="strArray"></param>
        /// <param name="numArray"></param>
        /// <returns>
        /// A dictionary made of strings and ints, Keys and Values, respectively.
        /// </returns>
        public static Dictionary<string, int> MakeDict2(string[] strArray, int[] numArray)
        {
            var arrayDict = new Dictionary<string, int>();
            for (int i = 0; i < strArray.Length; i++)
            {
                arrayDict.Add(strArray[i], numArray[i]);
            }
            return arrayDict;
        }
    }
}
