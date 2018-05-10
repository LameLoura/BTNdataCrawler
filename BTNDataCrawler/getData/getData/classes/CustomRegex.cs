using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace getData.classes
{
    class CustomRegex
    {
        //public static bool GetRegex(string input)
        //{ 
        //    string regex = "<td><a href=" + ".*" + " width=\"75\" height=\"75\" /></a></td>";
        //    Match result =  Regex.Match(input, regex);
        //    return result.Success;
        //}

        public static string RomoveMatchedRegex(string input , string pattern)
        {
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                return regex.Replace(input, string.Empty);
        }


        public static bool IfMatchRegex(string input, string regex)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            Match result = Regex.Match(input, regex);
            return result.Success;
        }


        public static List<string> ListOfMatchedBid(string input, string pattern)
        {
            List<string> answer = new List<string>();
            //string pattern = @"\b(\w+?)\s\1\b";
            //string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                answer.Add(match.Value);
                //Console.WriteLine("{0} (duplicates '{1}') at position {2}",
                //                  match.Value, match.Groups[1].Value, match.Index);
            return answer;
        }
    }
}
