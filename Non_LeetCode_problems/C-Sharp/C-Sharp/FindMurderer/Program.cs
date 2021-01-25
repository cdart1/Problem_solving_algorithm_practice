using System;
using System.Collections.Generic;

namespace FindMurderer
{
    class Program
    {
        /// <summary>
        /// Find the killer! 
        /// You have managed to narrow the suspects down to just a few. Luckily, you know every person 
        /// who those suspects have seen on the day of the murders. Given a dictionary with all the 
        /// names of the suspects and everyone that they have seen on that day and also a list of the 
        /// names of the dead people return the name of the one killer.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<string> deadList = new List<string>() { "Lucas", "Bill" };
            HashSet<string> dead = new HashSet<string> { "Lucas", "Bill" };
            var dict = new Dictionary<string, List<string>>()
            {
                //{ "Petr", new List<string> { "Bill" } },
                {"James", new List<string> { "Jacob", "Bill", "Lucas" } },
                { "Johnny", new List<string> { "David", "Kyle", "Lucas" } },
                { "Peter", new List<string> { "Lucy", "Kyle" } }
            };
            //Console.WriteLine(KillerName(dead, dict));
            Console.WriteLine(KillerName2(deadList, dict));
        }
        public static string KillerName(HashSet<string> dead, Dictionary<string, List<string>> dict)
        {
            string name = "";
            int count = 0;
            foreach (KeyValuePair<string, List<string>> kvp in dict)
            {
                foreach (string val in kvp.Value)
                {
                    if (dead.Contains(val))
                    {
                        count++;
                        if (count == dead.Count)
                        {
                            return kvp.Key; 
                        }
                    }
                }
            }
            return name;
        }

        public static string KillerName2(List<string> deadList, Dictionary<string, List<string>> dict)
        {
            string killer = "";
            var mentionedName = new Dictionary<string, int>();
            foreach (KeyValuePair<string, List<string>> kvp in dict)
            {
                foreach (string val in kvp.Value)
                {
                    for (int i = 0; i < deadList.Count; i++)
                    {
                        if (deadList[i] == val && mentionedName.ContainsKey(kvp.Key))
                        {
                            mentionedName[kvp.Key]++;
                        }
                        else if (deadList[i] == val && !mentionedName.ContainsKey(kvp.Key))
                        {
                            mentionedName.Add(kvp.Key, 1);
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, int> kvp in mentionedName)
            {
                if (kvp.Value == deadList.Count)
                {
                    killer = kvp.Key;
                }
            }
            return killer;
        }
    }
}
