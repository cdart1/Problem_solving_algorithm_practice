using System;
using System.Collections.Generic;
using System.Text;

namespace ToLowerCase
{
    class ToLowerCaseProblem
    {
        /// <summary>
        /// Created a dictionary of captial letter 'keys' and lowercase letter 'values'. Checks if 'alphabetDict' contains 
        /// each character. If the character matches the 'key' then append the 'value' to 'sb'. Otherwise, append the 
        /// current character from input 's' to 'sb'.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>
        /// Returns an all lowercase string.
        /// </returns>
        public static string ToLowerCase(string s)
        {
            var alphabetDict = new Dictionary<char, char>()
            {
                ['A']='a', ['B']='b', ['C']='c', ['D']='d', ['E']='e', ['F']='f', ['G']='g', ['H']='h', ['I']='i', ['J']='j',
                ['K']='k', ['L']='l', ['M']='m', ['N']='n', ['O']='o', ['P']='p', ['Q']='q', ['R']='r', ['S']='s', ['T']='t',
                ['U']='u', ['V']='v', ['W']='w', ['X']='x', ['Y']='y', ['Z']='z'
            };
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (alphabetDict.ContainsKey(s[i]))
                {
                    char key = s[i];
                    sb.Append(alphabetDict[key]);
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Uses the ASCii decimal code to convert each character to an integer. Checks if 'asciiNum' is uppercase character 
        /// (between integers 65 and 90) inclusively. If so, add 32 to get the corresponding lowercase integer, convert the 
        /// lowercase integer to a character, and append it to 'sb'. Otherwise, append the current character from input 's' to 'sb'.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>
        /// Returns an all lowercase string.
        /// </returns>
        public static string ToLowerCase2(string s)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                int asciiNum = Convert.ToInt32(s[i]);
                if (asciiNum >= 65 && asciiNum <= 90)
                {
                    int lowerCaseAscii = asciiNum + 32;
                    sb.Append(Convert.ToChar(lowerCaseAscii));
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }
    }
}
