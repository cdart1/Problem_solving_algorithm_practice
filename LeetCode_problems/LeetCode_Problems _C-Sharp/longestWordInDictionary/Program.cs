using System;
using System.Collections.Generic;
using System.Linq;

namespace longestWordInDictionary
{
    class Program
    {
        /* Given a list of strings words representing an English Dictionary, find the longest word 
         * in words that can be built one character at a time by other words in words.If there is 
         * more than one possible answer, return the longest word with the smallest lexicographical order.

            If there is no answer, return the empty string.
            Example 1:
            Input: 
            words = ["w", "wo", "wor", "worl", "world"]
            Output: "world"
            Explanation: 
            The word "world" can be built one character at a time by "w", "wo", "wor", and "worl".

            Example 2:
            Input: 
            words = ["a", "banana", "app", "appl", "ap", "apply", "apple"]
            Output: "apple"
            Explanation: 
            Both "apply" and "apple" can be built from other words in the dictionary. However, "apple" is 
            lexicographically smaller than "apply".

            Note:
            All the strings in the input will only contain lowercase letters.
            The length of words will be in the range [1, 1000].
            The length of words[i] will be in the range [1, 30].
        */

        static void Main(string[] args)
        {
            string[] words = new string[] { "d", "do", "dog", "p", "pe", "pen", "peng", "pengu", "pengui", "penguin", "e", "el", "ele", "elep", "eleph", "elepha", "elephan", "elephant" };
            string[] words2 = new string[] { "a", "banana", "app", "appl", "ap", "apply", "apple" };
            string[] words3 = new string[] { "w", "wo", "wor", "worl", "world" };
            string[] words4 = new string[] { "ts", "e", "x", "pbhj", "opto", "xhigy", "erikz", "pbh", "opt", "erikzb", "eri", "erik", "xlye", "xhig", "optoj", "optoje", "xly", "pb", "xhi", "x", "o" };
            string answer = LongestWordProblem.LongestWord(words);
            string answer2 = LongestWordProblem.LongestWord(words2);
            string answer3 = LongestWordProblem.LongestWord(words3);
            Console.WriteLine(answer);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine("=======================");
            string answer4 = LongestWordProblem.LongestWord2(words);
            string answer5 = LongestWordProblem.LongestWord2(words2);
            string answer6 = LongestWordProblem.LongestWord2(words3);
            Console.WriteLine(answer4);
            Console.WriteLine(answer5);
            Console.WriteLine(answer6);
            //string answer = LongestWord(words4);
            //Console.WriteLine(answer);
        }
    }
}
