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
                while (i < j && !char.IsLetter(characters[i]))
                {
                    i++;
                }
                while (j > i && !char.IsLetter(characters[j]))
                {
                    j--;
                }
                char temp = characters[i];
                characters[i++] = characters[j];
                characters[j--] = temp;
            }
            return new string(characters);
        }
    }
}
