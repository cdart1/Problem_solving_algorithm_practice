using System;
using System.Collections.Generic;
using System.Text;

namespace SortedOrderArray
{
    public class SortedOrderArrayProblem
    {
        public static bool SortArrayAscending(int[] a)
        {
            int[] b = new int[a.Length];
            int i = 0;
            int j = a.Length - 1;

            if (a.Length == 1)
            {
                return true;
            }

            if (a.Length % 2 == 0)
            {
                int index = 0;
                while (i < j)
                {
                    b[index] = a[i];
                    index = index + 1;
                    b[index] = a[j];
                    index = index + 1;
                    i++;
                    j--;
                }
            }
            else
            {
                int index = 0;
                while (i <= j)
                {
                    b[index] = a[i];
                    index = index + 1;
                    b[index] = a[j];
                    index = index + 1;
                    i++;
                    j--;
                    if (i != j)
                    {
                        break;
                    }
                }
            }

            for (int k = 0; k < b.Length - 1; k++)
            {
                if (b[k] > b[k + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SortArrayAscending2(int[] input)
        {
            int?[] a = new int?[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                a[i] = input[i];
            }
            int[] b = new int[a.Length];
            int forwardVal = 0;
            int backwardVal = 0;
            int j = a.Length - 1;
            int index = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != null)
                {
                    forwardVal = (int)a[i];
                    b[index] = forwardVal;
                    index = index + 1;
                    a[i] = null;
                }
                if (a[j] != null)
                {
                    backwardVal = (int)a[j];
                    b[index] = backwardVal;
                    index = index + 1;
                    a[j] = null;
                }
                j--;
            }
            for (int k = 0; k < b.Length - 1; k++)
            {
                if (b[k] > b[k + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
