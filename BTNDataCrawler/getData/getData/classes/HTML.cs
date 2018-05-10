using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace getData.classes
{
    public class HTML
    {
        public string URL { get; private set; }
        public string Content { get; private set; }

        private Dictionary<string, string> _Attribute;
        public Dictionary<string, string> Attribute
        {
            get
            {
                if (_Attribute == null)
                {
                    _Attribute = new Dictionary<string, string>();
                    int start = Content.IndexOf("<") + 1;
                    int stop = Content.IndexOf(">") - 1 < 0 ? Content.Length - 1 : Content.IndexOf(">") - 1;
                    string answer = Content.Substring(start, stop);



                    List<string> listOfAttribute = CustomRegex.ListOfMatchedBid(this.Content, "\\s*?[^\\s]*?\\s*?=\".*?\"");


                    //string[] listOfAttribute = answer.Split(' ');
                    foreach (string eachAttribute in listOfAttribute)
                    {
                        if (eachAttribute.Contains("="))
                        {
                            int equalIndex = eachAttribute.IndexOf("=") + 1;
                            _Attribute.Add(eachAttribute.Substring(0, equalIndex - 1).Trim(),
                                               eachAttribute.Substring(equalIndex).Trim('"').Trim());
                        }

                    }
                }
                return _Attribute;

            }
        }


        public HTML(string HtmlContent)
        {
            Content = HtmlContent;
        }

        public HTML(string URL, string postMethod)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(URL);
            myRequest.Method = postMethod;
            WebResponse myResponse = myRequest.GetResponse();

            using (StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Content = sr.ReadToEnd();
                sr.Close();
            }
            myResponse.Close();
        }

        /// <summary>
        /// remove string in the most outer tag.
        /// if the given name doesn't exist, it throw error
        /// </summary>
        /// <param name="expectedOutTagName"></param>
        /// <returns></returns>
        public void stripOuterHtml(string expectedOutterTagName)
        {
            //for easier to use and code,,  well, fuck the perfornance issue
            string noLineCOntent = Content.Replace(System.Environment.NewLine, string.Empty).Trim();

            string openTagPattern = string.Format("^<\\s*{0}( .*?)*?>", expectedOutterTagName);
            string endTagPattern = string.Format("</\\s*{0}( .*)*>$", expectedOutterTagName);
            if (CustomRegex.IfMatchRegex(noLineCOntent, openTagPattern)
                && CustomRegex.IfMatchRegex(noLineCOntent, endTagPattern))
            {
                noLineCOntent = CustomRegex.RomoveMatchedRegex(noLineCOntent, openTagPattern);

                noLineCOntent = CustomRegex.RomoveMatchedRegex(noLineCOntent, endTagPattern);

                //                string pattern = "(\"formatter\": )\"(.*)\"( })";
                //var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                //                noLineCOntent = regex.Replace(
            }
            //{
            //}

            Content = noLineCOntent;

        }

        public static List<string> GetListOfAllMatchData(string data, string pattern)
        {
            List<string> listFOrce = new List<string>();
            listFOrce.Add(pattern);
            return GetListOfAllMatchData(data, listFOrce);
        }

        public static List<string> GetListOfAllMatchData(string data, List<string> pattern)
        {
            List<string> answer = new List<string>();
            using (StringReader reader = new StringReader(data))
            {
                int lineCOunter = 0;
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        //string teststring = "<td><a href=\"pastor.html\"><img src=\"images/pastor_face.png\" alt=\"Pastor Carter\" width=\"75\" height=\"75\" /></a></td>";
                        //teststring = "";
                        foreach (string eachPattern in pattern)
                        {
                            if (CustomRegex.IfMatchRegex(line, eachPattern))
                            {
                                answer.Add(line);
                                continue;
                            }
                        }
                    }
                    lineCOunter++;
                } while (line != null);
            }
            return answer;
        }

        public static List<string> GetListOfAllFavouriteLine(string data)
        {
            List<string> answer = new List<string>();
            using (StringReader reader = new StringReader(data))
            {
                string FavourStatus = string.Empty;
                int saveflag = -1;
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {

                        string pattern = "<td background=\"images/villager_bg.png\"><strong>.*</strong></td>";
                        if (CustomRegex.IfMatchRegex(line, pattern))
                        {
                            saveflag = 3;
                            FavourStatus = line.Replace("<td background=\"images/villager_bg.png\"><strong>", string.Empty)
                                .Replace("</strong></td>", string.Empty).Trim();
                        }

                        if (saveflag == 0)
                        {
                            HTML stippedData = new HTML(line);
                            stippedData.stripOuterHtml("td");

                            answer.Add(string.Format("{0} : {1}", FavourStatus, stippedData.Content));
                        }

                    }
                    saveflag--;
                } while (line != null);
            }
            return answer;
        }


        public static List<string> GetListOfAllRecipe(string data)
        {
            List<string> answer = new List<string>();
            using (StringReader reader = new StringReader(data))
            {
                string RecipeName = "UnAssigned";
                string line = string.Empty;
                string keyName = string.Empty;
                do
                {

                    line = reader.ReadLine();
                    if (line != null)
                    {
                        //its the header
                        if (CustomRegex.IfMatchRegex(line, "<td width=\"150\" background=\"images/recipe_bg.png\"><strong><a name=\".*"))
                        {
                            HTML recipeHtml = new HTML(line);
                            recipeHtml.stripOuterHtml("td");
                            recipeHtml.stripOuterHtml("strong");
                            recipeHtml.stripOuterHtml("a");
                            RecipeName = recipeHtml.Content;
                            answer.Add(RecipeName);
                        }
                        //answer.Add(string.Format("{0} : {1}", key, value));

                    //else : the key value
                        else if (!string.IsNullOrEmpty(keyName))
                        {
                            string value = line.Replace("<td>", string.Empty).Replace("</td>", string.Empty);
                            answer.Add(string.Format("{0}{1}", keyName, value));

                            //reset key name
                            keyName = string.Empty;
                        }
                        //its the key of indegreient
                        else if (line.Contains("Required") || line.Contains("Optional"))
                        {
                            string[] Key = line.Split(new string[] { "</div></td>" }, StringSplitOptions.None);
                            string key = Key[0].Replace("<td><div align=\"left\">", string.Empty);
                            keyName = key;
                            //string value = Key[1].Replace("<td>", string.Empty).Replace("</td>", string.Empty);

                        }
                    }

                } while (line != null);
            }
            return answer;

        }

    }
}
