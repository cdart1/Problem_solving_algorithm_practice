using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a routine that reverses a string in place.
            string name = "Wilson";
            string reverse = ReverseStringProblem.ReverseStr(name);
            Console.WriteLine(reverse);
            Console.WriteLine("===============");
            string reverse2 = ReverseStringProblem.ReverseStr2(name);
            Console.WriteLine(reverse2);
        }
    }
}
