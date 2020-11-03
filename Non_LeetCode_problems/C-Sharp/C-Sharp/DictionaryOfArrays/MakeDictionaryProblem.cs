using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOfArrays
{
    class MakeDictionaryProblem
    {
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
        public static Dictionary<string, int> MakeDict2(string[] strArray, int[] numArray)
        {
            // With the same length, we can use 'i' to iterate through both arrays.
            var arrayDict = new Dictionary<string, int>();
            for (int i = 0; i < strArray.Length; i++)
            {
                arrayDict.Add(strArray[i], numArray[i]);
            }
            return arrayDict;
        }
    }
}
