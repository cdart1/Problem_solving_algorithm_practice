using System;

namespace NumberOfStepsToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 14;
            int answer = StepsToZeroProblem.ReduceToZero2(num);
            Console.WriteLine(answer);
        }
    }
}
