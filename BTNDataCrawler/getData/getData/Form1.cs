using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using getData.classes;
using System.IO;
using getData.objcects;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Threading;

namespace getData
{
    public partial class Form1 : Form
    {

        private void RandomTest()
        {
            HTML xx = new HTML("<td><div align=\"center\"><a href=\"rick.html\">Rick</a></div></td>");
            //xx.stripOuterHtml("td");
            //xx.stripOuterHtml("div");

            //Dictionary<string, string> test = xx.Attribute;
            //xx.stripOuterHtml("a");

            xx = new HTML("<Name>&lt;img src=\"images/doctor_face.png\" alt=\"Doctor Tim\" width=\"75\" height=\"75\" /&gt;</Name>");
            xx.stripOuterHtml("Name");
            Dictionary<string, string> XXX = xx.Attribute;
            CustomRegex.ListOfMatchedBid(xx.Content, ".*?=\".*?\"");

            List<string> xxsx = new List<string>();
            xxsx.Add("sadsads");
            xxsx.Add("sadsads");

            //CharacterFavourite xxx = new CharacterFavourite() { LovedItem = xxsx, DislikedItem = xxsx, HatedItem = xxsx };

            //string a = Xmls.WriteXML(xxx);
            //string b = "B";
        }

        public Form1()
        {
            InitializeComponent();
            RandomTest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HTML charcaterList = new HTML("http://harvestmoonbacktonatureguide.com/characters.html", "POST");
            txtAll.Text = charcaterList.Content;
        }

        private void btnGetListFromText_Click(object sender, EventArgs e)
        {
            //read each data of the given text
            //List<string> characterLine = HTML.GetListOfAllMatchData(txtAll.Text, "<td><a href=" + ".*" + " width=\"75\" height=\"75\" /></a></td>");
            List<string> listOfPattern = new List<string>();
            listOfPattern.Add("<td><a href=" + ".*" + " width=\"75\" height=\"75\" /></a></td>");
            listOfPattern.Add("<td width=\"75\"><a href=" + ".*" + " width=\"75\" height=\"75\" /></a></td>");
            List<string> characterLine = HTML.GetListOfAllMatchData(txtAll.Text, listOfPattern);

            List<Character> lsitOfcharacter = new List<Character>();
            foreach (string character in characterLine)
            {
                HTML xx = new HTML(character);
                xx.stripOuterHtml("td");
                xx.stripOuterHtml("div");
                string link = xx.Attribute["href"];
                xx.stripOuterHtml("a");
                string name = xx.Attribute["alt"];

                Character newCharacter = new Character(link, name);
                lsitOfcharacter.Add(newCharacter);
            }


            string test = Xmls.WriteXML(lsitOfcharacter);
            string a = "ends";
        }



        private void btnGetCharacter_Click(object sender, EventArgs e)
        {
            List<Character> characters = Xmls.DeserializeObject(txtXmlPath.Text);
        }

        //private void DoTheLoad()//(object sender, EventArgs e)
        //{
        //    for (int progress = 1; progress <= 100; progress++)
        //    {
        //        System.Threading.Thread.Sleep(20);

        //        // Update the wait window message
        //        pgbWaitLoadCharFavour.Value = doneCOunt;
        //        //txtLoadInfo.Text = string.Format("Loaded {0} out of 27", doneCOunt.ToString());
        //    }
        //}


        //private void btnGetCharFavourite_Click(object sender, EventArgs e)
        private void btnGetCharFavourite_Click(object sender, EventArgs e)
        {

            int doneCOunt = 0;
            pgbWaitLoadCharFavour.Maximum = 27;
            //Thread workerThread = new Thread(new ThreadStart(this.DoTheLoad));
            //workerThread.Start();

            List<Character> characters = Xmls.DeserializeObject(txtXmlPath.Text);
            List<CharacterFavourite> charFavour = new List<CharacterFavourite>();
            StringBuilder error = new StringBuilder();

            foreach (Character man in characters)
            {
                string charName = "unassginedYet";
                try
                {
                    charName = man.Link;
                    string link = string.Format("http://harvestmoonbacktonatureguide.com/{0}", man.Link);
                    HTML charcaterList = new HTML(link, "POST");

                    CharacterFavourite eachFavour = new CharacterFavourite() { characterLink = man.Link };
                    txtAll.Text = charcaterList.Content;
                    List<string> favourListLine = HTML.GetListOfAllFavouriteLine(charcaterList.Content);
                    foreach (string loveList in favourListLine)
                    {

                        if (loveList.ToLower().Contains("dislike"))
                            eachFavour.DislikedItem = loveList;
                        else if (loveList.ToLower().Contains("love"))
                            eachFavour.LovedItem = loveList;
                        else if (loveList.ToLower().Contains("like"))
                            eachFavour.LikedItem = loveList;
                        else if (loveList.ToLower().Contains("neutral"))
                            eachFavour.NauturalItem = loveList;
                        else if (loveList.ToLower().Contains("hate"))
                            eachFavour.HatedItem = loveList;
                        else
                            eachFavour.ElseItem += loveList;
                    }
                    charFavour.Add(eachFavour);
                    doneCOunt++;

                    pgbWaitLoadCharFavour.Value += 1;
                    // txtLoadInfo.Text = string.Format("Loaded {0} out of 27", doneCOunt.ToString());
                }
                catch
                {
                    error.AppendLine(string.IsNullOrEmpty(error.ToString()) ? string.Empty : ", " + charName);
                    continue;
                }
            }

            string test = Xmls.WriteXML(charFavour);
            string f = "";
            //HTML charcaterList = new HTML("http://harvestmoonbacktonatureguide.com/anna.html", "POST");
            //txtAll.Text = charcaterList.Content;
            //List<string> favourList =  HTML.GetListOfAllFavourite(charcaterList.Content);
            //string d = string.Empty;
        }

        private void btnGetAllItem_Click(object sender, EventArgs e)
        {
            string ColumnNmae = "Items";
            DataTable pap = new DataTable();
            pap.Columns.Add(ColumnNmae);

            //for (int runner = 0; runner < 8; runner++)
            //{
            //    DataRow zz = pap.NewRow();
            //    zz["Items"] = "adsasd";
            //    pap.Rows.Add(zz);
            //}

            List<CharacterFavourite> characterFavs = Xmls.DeserializeCharaFav(txtCharFav.Text);
            foreach (CharacterFavourite favour in characterFavs)
            {
                StringBuilder allItem = new StringBuilder();
                allItem.Append((string.IsNullOrEmpty(allItem.ToString()) ? string.Empty : ", ") + favour.DislikedItem);
                allItem.Append((string.IsNullOrEmpty(allItem.ToString()) ? string.Empty : ", ") + favour.HatedItem);
                allItem.Append((string.IsNullOrEmpty(allItem.ToString()) ? string.Empty : ", ") + favour.LikedItem);
                allItem.Append((string.IsNullOrEmpty(allItem.ToString()) ? string.Empty : ", ") + favour.NauturalItem);
                allItem.Append((string.IsNullOrEmpty(allItem.ToString()) ? string.Empty : ", ") + favour.LovedItem);

                string[] ALlItemArray = allItem.ToString().Split(',');
                foreach (string item in ALlItemArray)
                {
                    string filter = string.Format("{0} = '{1}'", ColumnNmae.Trim(), item.Trim());
                    if (pap.Select(filter).ToList().Count == 0)
                    {
                        DataRow eachDataRow = pap.NewRow();
                        eachDataRow[ColumnNmae] = item.Trim();
                        pap.Rows.Add(eachDataRow);
                    }
                }
            }

            string a = "Please check data in the DataTable";
            //foreach(CharacterFavourite favour in characterFavs )
            //{
            //    Datarow
            //}
        }

        private void btnGetHtmlCooking_Click(object sender, EventArgs e)
        {
            HTML charcaterList = new HTML(txtCookingLink.Text, "POST");
            txtAll.Text = charcaterList.Content;
            string RecipeName = "unAssigned";

            List<string> answer = HTML.GetListOfAllRecipe(txtAll.Text);
            List<Recipe> realanswer = new List<Recipe>();

            Recipe eachRecipe = new Recipe();
            foreach (string relatedHtml in answer)
            {

                string[] keyNVAlue = relatedHtml.Split(':');
                if (keyNVAlue.Length > 1)
                {
                    string key = keyNVAlue[0];
                    string value = keyNVAlue[1].Replace("\"", string.Empty).Replace("-", string.Empty).Trim();

                    if (key.Contains("Required Utensils"))
                        eachRecipe.RequiredUtensils = value;
                    else if (key.Contains("Required Ingredients"))
                        eachRecipe.RequiredIngredients = value;
                    else if (key.Contains("Required Seasoning"))
                        eachRecipe.RequiredSeasoning = value;
                    else if (key.Contains("Optional Utensils"))
                        eachRecipe.OptionalUtensils = value;
                    else if (key.Contains("Optional Ingredients"))
                        eachRecipe.OptionalIngredients = value;
                    else if (key.Contains("Optional Seasoning"))
                    {
                        eachRecipe.OptionalSeasoning = value;
                        realanswer.Add(eachRecipe);
                        eachRecipe = new Recipe();
                    }
                }
                else
                {
                    eachRecipe.RecipeName = relatedHtml;
                }


            }
            string yeahh =  Xmls.WriteXML(realanswer);

            string zzz = string.Empty;
            //try
            //{
            //    charName = man.Link;
            //    string link = string.Format("http://harvestmoonbacktonatureguide.com/{0}", man.Link);
            //    HTML charcaterList = new HTML(link, "POST");

            //    CharacterFavourite eachFavour = new CharacterFavourite() { characterLink = man.Link };
            //    txtAll.Text = charcaterList.Content;
            //    List<string> favourListLine = HTML.GetListOfAllFavouriteLine(charcaterList.Content);
            //    foreach (string loveList in favourListLine)
            //    {

            //        if (loveList.ToLower().Contains("dislike"))
            //            eachFavour.DislikedItem = loveList;
            //        else if (loveList.ToLower().Contains("love"))
            //            eachFavour.LovedItem = loveList;
            //        else if (loveList.ToLower().Contains("like"))
            //            eachFavour.LikedItem = loveList;
            //        else if (loveList.ToLower().Contains("neutral"))
            //            eachFavour.NauturalItem = loveList;
            //        else if (loveList.ToLower().Contains("hate"))
            //            eachFavour.HatedItem = loveList;
            //        else
            //            eachFavour.ElseItem += loveList;
            //    }
            //    charFavour.Add(eachFavour);
            //    doneCOunt++;

            //    pgbWaitLoadCharFavour.Value += 1;
            //   // txtLoadInfo.Text = string.Format("Loaded {0} out of 27", doneCOunt.ToString());
            //}
            //catch
            //{
            //    error.AppendLine( string.IsNullOrEmpty(error.ToString()) ? string.Empty : ", " + charName );
            //    continue;
            //}

        }

        private void btnGetRecipeCLass_Click(object sender, EventArgs e)
        {

            List<Recipe> characters = Xmls.DeserializeRecipe(txtXmlRecipePath.Text);
            string LoveTangForever = "lovePongToo";
        }


    }
}
