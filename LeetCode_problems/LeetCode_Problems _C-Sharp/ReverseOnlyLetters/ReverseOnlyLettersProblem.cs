using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseOnlyLetters
{
    class ReverseOnlyLettersProblem
    {
        public static string reverseOnlyLetters(string s)
        {
            char[] characters = s.ToCharArray();
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                while (!char.IsLetter(characters[i]))
                {
                    i++;
                }
                while (!char.IsLetter(characters[j]))
                {
                    j--;
                }
                char temp = characters[i];
                characters[i] = characters[j];
                characters[j] = temp;
                i++;
                j--;
            }
            return new string(characters);
        }
    }
}
