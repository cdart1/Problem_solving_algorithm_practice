using System;
using System.Collections.Generic;

namespace TranslateGreeting
{
    class Program
    {
        /// <summary>
        /// Returns a value from key value pairs based user input.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Dictionary<string, string> greetings = new Dictionary<string, string>()
            {
                { "english", "Welcome" },
                { "czech", "Vitejte" },
                { "danish", "Velkomst" },
                { "dutch", "Welkom" },
                { "estonian", "Tere tulemast" },
                { "finnish", "Tervetuloa" },
                { "flemish", "Welgekomen" },
                { "french", "Bienvenue" },
                { "german", "Willkommen" },
                { "irish", "Failte" },
                { "italian", "Benvenuto" },
                { "latvian", "Gaidits" },
                { "lithuanian", "Laukiamas" },
                { "polish", "Witamy" },
                { "spanish", "Bienvenido" },
                { "swedish", "Valkommen" },
                { "welsh", "Croeso" },

            };
            Console.WriteLine("Translate 'Welcome' into another language.\n" +
                "For example:\nIf you type 'italian' the greeting message will say 'Benvenuto'.");

            bool go = true;
            while (go)
            {
                Console.WriteLine("Please type a language: \n");
                string language = Console.ReadLine().ToLower();
                Console.WriteLine(GreetingTranslator(language, greetings));

                Console.WriteLine("Want to keep translating? Type 'y' or 'n': ");
                string ans = Console.ReadLine().ToLower();
                if (ans == "y") go = true;
                else go = false;
            }
        }

        static string GreetingTranslator(string language, Dictionary<string, string> greetings)
        {
            if (!greetings.ContainsKey(language))
            {
                return "\nSorry I couldn't find that language.\n";
            }
            else
            {
                return greetings[language];
            }
        }

    }
}
