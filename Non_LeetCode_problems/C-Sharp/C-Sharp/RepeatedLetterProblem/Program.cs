using System;

namespace RepeatedLetterInString
{
    class Program
    {
        // Given strings eg. "nicson" return the amount of times you see letter "n"
        static void Main(string[] args)
        {
            string name = "nancy";
            int letterCount = RepeatedLetterProblem.RepeatedLetter(name);
            Console.WriteLine(letterCount);
        }
    }
}
