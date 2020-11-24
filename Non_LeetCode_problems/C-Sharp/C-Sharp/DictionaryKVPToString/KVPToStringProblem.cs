using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryKVPToString
{
    class KVPToStringProblem
    {
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
        
        public static string KVPToString2(Dictionary<string, int> dictionary)
        {
            string string1 = "a" + dictionary["a"].ToString();
            string string2 = "b" + dictionary["b"].ToString();
            string string3 = "c" + dictionary["c"].ToString();
            return string1 + string2 + string3;
        }
    }
}
