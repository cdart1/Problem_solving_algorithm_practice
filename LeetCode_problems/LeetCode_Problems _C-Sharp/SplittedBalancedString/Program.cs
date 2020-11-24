using System;

namespace SplittedBalancedString
{
    class Program
    {
        /* Balanced strings are those who have equal quantity of 'L' and 'R' characters.

            Given a balanced string s split it in the maximum amount of balanced strings.

            Return the maximum amount of splitted balanced strings.

            Example 1:

            Input: s = "RLRRLLRLRL"
            Output: 4
            Explanation: s can be split into "RL", "RRLL", "RL", "RL", each substring contains same number of 'L' and 'R'.
         */
        static void Main(string[] args)
        {
            string s = "RLRRLLRLRL";
            int answer = SplittedBalancedStringProblem.SplitBalancedString(s);
            Console.WriteLine(answer);
        }
    }
}
