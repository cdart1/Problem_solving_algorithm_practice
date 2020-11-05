using System;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // You are given an array of positive numbers from 1 to n, such that all numbers from 1 to n are present except one number (x). 
            // You have to find x. The input array is not sorted.

            int[] numArray = { 3, 7, 1, 2, 8, 4, 5 };
            int x = MissingNumProblem.MissingNum(numArray);
            Console.WriteLine("x = {0}",x);
        }
    }
}
