using System;
using System.Collections.Generic;
using System.Text;

namespace NumberOfStepsToZero
{
    class StepsToZeroProblem
    {
        public static int ReduceToZero(int num)
        {
            int count = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    count++;
                }
                else
                {
                    num = num - 1;
                    count++;
                }
            }
            return count;
        }

        public static int ReduceToZero2(int num)
        {
            int count = 0;
            return Recursion(num, count);
        }

        public static int Recursion(int num, int count)
        {
            if (num > 0 && num % 2 == 0)
            {
                num = num / 2;
                count++;
                return Recursion(num, count);
            }
            else if (num > 0 && num % 2 != 0)
            {
                num = num - 1;
                count++;
                return Recursion(num, count);
            }
            return count;
        }
    }
}
