using System;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string return the number of vowels contained in that string.  

            string phrase = "Hello World";

            int vowelCount = VowelCountProblem.VowelCount(phrase);
            Console.WriteLine(vowelCount);
            Console.WriteLine("===================");
            
            int vowelCount2 = VowelCountProblem.VowelCount2(phrase);
            Console.WriteLine(vowelCount2);
        }
    }
}
