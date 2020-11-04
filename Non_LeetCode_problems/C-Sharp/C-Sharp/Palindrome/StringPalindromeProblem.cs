using System;
using System.Collections.Generic;
using System.Text;

namespace StringPalindrome
{
    class StringPalindromeProblem
    {
        /// <summary>
        /// Checking for a palindrome using two StringBuilders and two for loops (hard coded boolean values).
        /// </summary>
        /// <param name="str"></param>
        /// <returns>
        /// Returns true if it's a palindrome, returns false if it's not.
        /// </returns>
        public static bool IsPalindrome(string str)
        {
            // If you want to convert a collection of characters to strings, use StringBuilder.
            StringBuilder charList1 = new StringBuilder();
            StringBuilder charList2 = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                charList1.Append(str[i]);
                Console.WriteLine(str[i]);
            }
            // str.Length - 1 gives the last index of the string.
            for (int i = str.Length - 1; i >= 0; i--)
            {
                charList2.Append(str[i]);
                Console.WriteLine(str[i]);
            }
            // Can't compare collections eg. Lists, Arrays, Dictionaries, StringBuilder. Can only compare primative data types eg. int, string, char, bool.
            // That is why we use ToString().
            if (charList1.ToString() == charList2.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checking for a palindrome using two StringBuilders and two for loops (using a bool variable).
        /// </summary>
        /// <param name="str"></param>
        /// <returns>
        /// Returns true if it's a palindrome, returns false if it's not.
        /// </returns>
        public static bool IsPalindrome2(string str)
        {
            StringBuilder charList1 = new StringBuilder();
            StringBuilder charList2 = new StringBuilder();
            bool isPalindrome = false;

            for (int i = 0; i < str.Length; i++)
            {
                charList1.Append(str[i]);
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                charList2.Append(str[i]);
            }
            if (charList1.ToString() == charList2.ToString())
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }

        /// <summary>
        /// Checking for a palindrome using one StringBuilder, one for loop and compares it with the input string (using a bool variable).
        /// </summary>
        /// <param name="str"></param>
        /// <returns>
        /// Returns true if it's a palindrome, returns false if it's not.
        /// </returns>
        public static bool IsPalindrome3(string str)
        {
            StringBuilder charList = new StringBuilder();
            bool isPalindrome = false;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                charList.Append(str[i]);
            }
            Console.WriteLine(str + " " + charList.ToString());
            if (charList.ToString() == str)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }

        /// <summary>
        /// Checking for a palindrome using one character array, one for loop and compares it with the input string, and manually converting 
        /// the char array to a string (using a bool variable).
        /// </summary>
        /// <param name="str"></param>
        /// <returns>
        /// Returns true if it's a palindrome, returns false if it's not.
        /// </returns>
        public static bool IsPalindrome4(string str)
        {
            char[] charList2 = new char[str.Length];
            bool isPalindrome = false;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                charList2[i] = str[i];
            }
            
            // I'm converting charList1 and charList2 to strings.
            string string2 = new string(charList2);

            if (str == string2)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
