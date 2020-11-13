using System;
using System.Collections.Generic;
using System.Text;

namespace SplittedBalancedString
{
    // Stacks are useful when you need to balance something.
    class SplittedBalancedStringProblem
    {
        /// <summary>
        /// Using a stack allows each character 'R' in 's' to be added and removed once we have found it's counterpart 'L', 
        /// or viceversa. Once 'charStack' becomes empty there is a balanced pair and count increases.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>
        /// Returns the number of balanced pairs.
        /// </returns>
        public static int SplitBalancedString(string s)
        {
            int count = 0;
            Stack<char> charStack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (charStack.Count == 0)
                {
                    charStack.Push(s[i]);
                }
                else if (charStack.Peek() == s[i])
                {
                    charStack.Push(s[i]);
                }
                else if (charStack.Peek() != s[i])
                {
                    charStack.Pop();
                }

                if (charStack.Count == 0 && s[i] != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
