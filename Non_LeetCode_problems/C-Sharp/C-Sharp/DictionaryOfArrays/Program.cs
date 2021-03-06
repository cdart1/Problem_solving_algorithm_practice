﻿using System;
using System.Collections.Generic;

namespace DictionaryOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given 2 inputs, a string array and an int array, create a dictionary where the string is the key and the int is the value.
            string[] strArray = { "a", "b", "c", "d" };
            int[] numArray = { 1, 2, 3, 4 };

            var dict = MakeDictionaryProblem.MakeDict(strArray, numArray);
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("=======================");
            var dict2 = MakeDictionaryProblem.MakeDict2(strArray, numArray);
            foreach (KeyValuePair<string, int> kvp in dict2)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
