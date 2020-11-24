using System;

namespace ToLowerCase
{
    class Program
    {
        // https://leetcode.com/problems/to-lower-case/
        /* Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.

        Example 1:

        Input: "Hello"
        Output: "hello"
        */
        static void Main(string[] args)
        {
            string s = "HeLlO P3#";
            string answer = ToLowerCaseProblem.ToLowerCase2(s);
            Console.WriteLine(answer);
        }
    }
}
