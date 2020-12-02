using System;
using System.Collections.Generic;
using System.Text;

namespace AllMyAlgorithms
{
    public class KVPToStringProblem
    {
        /// <summary>
        /// Takes in a dictionary and converts the keys and values to a string.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns>
        /// A string of the keys and values.
        /// </returns>
        public static string KVPToString(Dictionary<string, int> dictionary)
        {
            string dictKey = "";
            string dictValue = "";
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                dictKey = kvp.Key;
                dictValue = kvp.Value.ToString();
                string kvString = dictKey + dictValue + " ";
                sb.Append(kvString);
            }
            return sb.ToString();
        }
        
        // Hard coded version of the above.
        public static string KVPToString2(Dictionary<string, int> dictionary)
        {
            string string1 = "a" + dictionary["a"].ToString();
            string string2 = "b" + dictionary["b"].ToString();
            string string3 = "c" + dictionary["c"].ToString();
            return string1 + string2 + string3;
        }
    }
}
