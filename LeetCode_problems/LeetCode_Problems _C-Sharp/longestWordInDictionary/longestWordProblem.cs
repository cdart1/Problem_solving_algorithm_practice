using System;
using System.Collections.Generic;
using System.Text;

namespace longestWordInDictionary
{
    public class LongestWordProblem
    {
        /// <summary>
        /// This method takes in an array of strings and gets the largest, lexicographically smallest string. 
        /// </summary>
        /// <param name="words"></param>
        /// <returns>This method return the longest string.</returns>
        public static string LongestWord(string[] words)
        {
            string ans = "";
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < words.Length; i++)
            {
                set.Add(words[i]);
            }
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].Length > ans.Length ||
                    // If the current lengths are equal and current string preceeds the 'ans'
                    words[j].Length == ans.Length && words[j].CompareTo(ans) < 0)
                {
                    bool isGood = true;
                    // 'k' starts at '1'. 'k' determines the number of characters in the substring.
                    for (int k = 1; k < words[j].Length; k++)
                    {
                        // If the set does contain the specified substring (this condition isn't hit)
                        if (!set.Contains(words[j].Substring(0, k)))
                        {
                            isGood = false;
                            break;
                        }
                    }
                    if (isGood)
                    {
                        ans = words[j];
                    }
                }
            }
            return ans;
        }


        /// <summary>
        /// This method takes an array and gets the lexicographically smallest 'answer' based on the length of 'goodList'. 
        /// <param name="words"></param>
        /// <returns>This method return the longest string.</returns>
        public static string LongestWord2(string[] words)
        {
            string answer = "";
            List<string> goodList = new List<string>();
            List<int> indexListSameLen = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                // goodList adds a string candidate after comparing lengths of the current string, 'word[i]' and the last 
                // string added in 'goodList'. 
                bool isCandidate = IsCandidate(words[i], words);
                if (isCandidate)
                {
                    if (goodList.Count == 0)
                    {
                        goodList.Add(words[i]);
                    }
                    if (goodList[goodList.Count - 1].Length < words[i].Length)
                    {
                        // This list's length, 'indexListSameLen' determines whether the last string in goodList gets replaces,
                        // or all strings get replaced with the current string, words[i].
                        if (indexListSameLen.Count <= 1)
                        {
                            goodList.RemoveAt(goodList.Count - 1);
                            goodList.Add(words[i]);
                        }
                        if (indexListSameLen.Count > 1)
                        {
                            goodList.Clear();
                            goodList.Add(words[i]);
                            indexListSameLen.Clear();
                        }
                    }
                    // If both string lengths are same or the the last string in gooList is larger, 
                    if (goodList[goodList.Count - 1].Length >= words[i].Length)
                    {
                        // make sure they the strings aren't identical and the last string in goodList is smaller or equal in length.
                        if (goodList[goodList.Count - 1] != words[i] && goodList[goodList.Count - 1].Length <= words[i].Length)
                        {
                            // If strings are equal lengths, add the current string to goodList and add the indexes
                            // in which the current string and the last string in goodlist are positioned.
                            if (goodList[goodList.Count - 1].Length == words[i].Length)
                            {
                                goodList.Add(words[i]);
                                indexListSameLen.Add(goodList.Count - 1);
                                indexListSameLen.Add(goodList.Count - 2);
                            }
                        }

                    }
                }
            }
            if (goodList.Count == 1)
            {
                answer = goodList[0];
            }
            if (goodList.Count > 1)
            {
                answer = LexicographicallySmallest(goodList);
            }
            return answer;
        }

        /// <summary>
        ///  This method takes an array and a string. It checks if a hashset contains a word and adds to the count.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="words"></param>
        /// <returns>This method returns a bool.</returns>
        public static bool IsCandidate(string word, string[] words)
        {
            bool isCandidate = false;
            int count = 0;
            string makingWord = "";
            HashSet<string> prefixList = new HashSet<string>();
            for (int i = 0; i < word.Length; i++)
            {
                makingWord += word[i].ToString();
                prefixList.Add(makingWord);
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (prefixList.Contains(words[i]))
                {
                    count++;
                }
                if (count == prefixList.Count)
                {
                    isCandidate = true;
                }
            }
            return isCandidate;
        }
        /// <summary>
        /// This method iterates through a list, compares lengths of two strings to get the smaller one.
        /// </summary>
        /// <param name="goodListStr"></param>
        /// <returns>This method returns the smallest string.</returns>
        //Find the smallest of the two strings after getting their ASCII values.
        public static string LexicographicallySmallest(List<string> goodListStr)
        {
            string smallest = "";
            for (int i = 0; i < goodListStr.Count-1; i++)
            {
                string str1 = goodListStr[i];
                string str2 = goodListStr[i + 1];
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str1[j] != str2[j])
                    {
                        if (str1[j] > str2[j])
                        {
                            smallest = str2;
                            return smallest;
                        }
                        if (str2[j] > str1[j])
                        {
                            smallest = str1;
                            return smallest;
                        }
                    }
                }
            }
            return smallest;
        }
    }
}
