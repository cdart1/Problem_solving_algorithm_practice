using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class CheckSumProblem
    {
        public static string CheckSum(int num1, int num2)
        {
            bool isGreater = true;
            if (num2 > num1)
            {
                return isGreater.ToString();
            }
            else if (num1 == num2)
            {
                string numsEqual = "-1";
                return numsEqual;
            }
            else
            {
                isGreater = false;
                return isGreater.ToString();
            }
        }

        public static string CheckSum2(int num1, int num2)
        {
            if (num2 > num1)
            {
                return "true";
            }
            else if (num1 == num2)
            {
                return "-1";
            }
            else
            {
                return "false";
            }
        }
    }
}
