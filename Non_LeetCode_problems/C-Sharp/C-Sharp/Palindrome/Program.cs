using System;
using System.Text;

namespace StringPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, return true if the string is a palindrome and false if it isn’t.

            string str = "racecar";
            string str2 = "jump rope";

            //int[] num = { 1, 2, 3, 4 };
            //int[] num2 = { 1, 2, 3, 4 };

            //if (num.ToString() == num2.ToString())
            //{
            //    Console.WriteLine("true");
            //}
            //Console.WriteLine("==================");




            bool answer = StringPalindromeProblem.IsPalindrome(str);
            Console.WriteLine(answer);
            Console.WriteLine("==================");
            bool answer2 = StringPalindromeProblem.IsPalindrome2(str);
            Console.WriteLine(answer2);
            Console.WriteLine("==================");
            bool answer3 = StringPalindromeProblem.IsPalindrome3(str);
            Console.WriteLine(answer3);
            Console.WriteLine("==================");


            /*
            // Can convert strings to char arrays easily. It's hard to convert char arrays to strings.
            StringBuilder sb = new StringBuilder();
            sb.Append("nicson");

            // string object (static)
            char[] name = "nicson".ToCharArray();
            // StringBuilder object (dynamic)
            char[] name2 = sb.ToString().ToCharArray();
            foreach (char c in name2)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("==================");

            // This logic doesn't work.
            string name3 = name.ToString();
            Console.WriteLine(name3);
            Console.WriteLine("==================");
            */
        }
    }
}
