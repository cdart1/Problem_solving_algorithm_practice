using System;
using System.Collections.Generic;
using System.Text;

namespace AreTwoStringArraysEquivalentProblem
{
    public class AreTwoStringArraysEquivalent
    {
        public static bool ArrayStringsAreEqual(string[] s1, string[] s2)
        {
            var sb = new StringBuilder();
            var sb2 = new StringBuilder();

            for (int i = 0; i < s1.Length; i++)
            {
                sb.Append(s1[i]);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                sb2.Append(s2[i]);
            }
            return sb.ToString() == sb2.ToString();
        }
    }
}
