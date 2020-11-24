using System;

namespace C_Sharp
{
    class Program
    {
        // Return string "true" if num2 is greater than num1. If they're equal return string "-1",
        // otherwise return string "false".
        static void Main(string[] args)
        {
            string check = CheckSumProblem.CheckSum2(10, 1);

            Console.WriteLine(check);
        }
    }
}
