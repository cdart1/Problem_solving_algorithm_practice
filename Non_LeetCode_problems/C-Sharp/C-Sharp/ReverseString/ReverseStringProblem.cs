using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    class ReverseStringProblem
    {
        /// <summary>
        /// Reverses a string by traversing backwards through the input string, appending each character to StringBuilder 'sb'.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// Returns a string in reversed order.
        /// </returns>
        public static string ReverseStr(string name)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                sb.Append(name[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Reverses a string by traversing backwards through the input string, adding each character to char[] 'namechar' starting from index 0.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// Returns a string in reversed order.
        /// </returns>
        public static string ReverseStr2(string name)
        {
            char[] namechar = new char[name.Length];
            int index = 0;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                namechar[index] = name[i];
                index++;
            }
            string namestr = new string(namechar);
            return namestr;
        }
    }
}
