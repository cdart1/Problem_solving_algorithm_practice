using System;
using System.Collections.Generic;
using System.Text;

namespace VowelCount
{
    class VowelCountProblem
    {
        /// <summary>
        /// I used a nested for loop to compare phrase characters with each vowel, increasing the count every time characters in 'phrase' equaled a vowel.
        /// Used a character array that holds the vowels.
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns>
        /// Returns the number of vowels found in the string.
        /// </returns>
        public static int VowelCount(string phrase)
        {
            char[] vowels = new char[5]
            {
                'a',
                'e',
                'i',
                'o',
                'u'
            };
            int count = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                foreach (char vowel in vowels)
                {
                    if (vowel == phrase[i])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// I used a for loop to check if a set of vowels contained a matching characters from the input string, increasing the count every a 
        /// character in 'phrase' was found in 'vowels'.
        /// Used a HashSet that holds the vowels.
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public static int VowelCount2(string phrase)
        {
            HashSet<char> vowels = new HashSet<char>
            {
                'a',
                'e',
                'i',
                'o',
                'u'
            };
            int count = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (vowels.Contains(phrase[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
