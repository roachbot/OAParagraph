using System;
using System.Collections.Generic;

namespace OAParagraph
{
    /// <summary>
    /// Program to list each distinct word and how many times it occurs in a paragraph
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new Exception ("Need one parameter, the paragraph.");
                }

                string input = args[0];

                //we can clean the input here with a variety of rules, did include one as an example
                input = Helper.CleanRules(input);

                //count the words
                Dictionary<string, int> Results = Helper.CountWords(input);

                //simple output to console, could dump in JSON, XML, File, etc.
                foreach (var result in Results)
                {
                    Console.WriteLine(string.Format("word : {0} count : {1}", result.Key, result.Value));
                }

                //Chill out for a bit to review results in console
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                //died, display it.
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}