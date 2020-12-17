using System;

namespace ReverseOnlyLetters
{
    class Program
    {
        // Given a string s, return the "reversed" string where all characters that are not a 
        // letter stay in the same place, and all letters reverse their positions.
        static void Main(string[] args)
        {
            string s = "Test1ng-Leet=code-Q!";
            string newS = ReverseOnlyLettersProblem.reverseOnlyLetters(s);
            Console.WriteLine(newS);
        }
    }
}
