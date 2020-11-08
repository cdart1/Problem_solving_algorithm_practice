using System;

namespace TotalThreeHighestNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, 5, 6 };
            int sum = Add3HighestNumsProblem.Add3Highest(inputArray);
            Console.WriteLine(sum);
        }
    }
}
