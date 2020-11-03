using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedLetterInString
{
    class RepeatedLetterProblem
    {
        public static int RepeatedLetter(string name)
        {
            int counter = 0;
            char letter = 'n';

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == letter)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
