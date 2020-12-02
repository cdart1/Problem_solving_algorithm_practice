using System;
using System.Collections.Generic;

namespace DictionaryKVPToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                {"a", 1 },
                {"b", 2 },
                {"c", 3 },
            };
            string outputString = KVPToStringProblem.KVPToString(dictionary);
            string outputString2 = KVPToStringProblem.KVPToString2(dictionary);
            Console.WriteLine(outputString);
            Console.WriteLine(outputString2);

//            a1 b2 c3
//              a1b2c3
        }
    }
}
