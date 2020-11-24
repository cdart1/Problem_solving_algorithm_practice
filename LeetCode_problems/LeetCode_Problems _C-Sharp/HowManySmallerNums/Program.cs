using System;
using System.Collections.Generic;

namespace HowManySmallerNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 8, 1, 2, 2, 3 };
            List<int> answers = CountSmallerNumsProblem.CountSmallerNums(nums);
            foreach (var answer in answers)
            {
                Console.WriteLine(answer);
            }
            Console.WriteLine("================");
            int[] answers2 = CountSmallerNumsProblem.CountSmallerNums2(nums);
            foreach (var answer in answers2)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
