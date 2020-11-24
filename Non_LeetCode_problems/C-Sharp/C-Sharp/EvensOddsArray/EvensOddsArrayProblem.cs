using System;
using System.Collections.Generic;
using System.Text;

namespace EvensOddsArray
{
    class EvensOddsArrayProblem
    {
        public static void EvensOdds(int[] numArray)
        {
            int numEven = 0;
            int numOdd = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                int evenCheck = numArray[i] % 2;
                Console.WriteLine(evenCheck);
                if (evenCheck == 0)
                {
                    numEven++;
                }
                else
                {
                    numOdd++;
                }
            }
            Console.WriteLine("Evens: " + numEven + " Odds: " + numOdd);
        }
    }
}
