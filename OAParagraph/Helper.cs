using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace OAParagraph
{
    /// <summary>
    /// Helper Class for OAParagraph
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Counts the words of an input string
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static Dictionary<string, int> CountWords(string input)
        {
            Dictionary<string, int> Results = new Dictionary<string, int>();

            //I would put in config file so we can change regex from simple to complicated if needed
            string pattern = @"\w+";

            Regex regexPattern = new Regex(pattern);
            MatchCollection matches = regexPattern.Matches(input);

            //if we have already in dictionary, increase counter, if not add it with 1 count
            foreach (Match m in matches)
            {
                if (Results.ContainsKey(m.Value))
                {
                    Results[m.Value]++;
                }
                else
                {
                    Results.Add(m.Value, 1);
                }
            }

            return Results;
        }

        /// <summary>
        /// This method will drive the preprocess of the input paragraph, in this example we will remove 's
        /// We can add many examples here like cleaning X.M.L to XMl etc.
        /// We can 'fix' contractions like won't didn't, etc in a rule
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>cleaned string of 's</returns>
        public static string CleanRules(string input)
        {
            string pattern = @"'s";
            Regex regexPattern = new Regex(pattern);
            input= regexPattern.Replace(input,"");
            return input;
        }
    }
}