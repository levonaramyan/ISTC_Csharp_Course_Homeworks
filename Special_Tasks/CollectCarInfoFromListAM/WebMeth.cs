using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace FirstProject
{
    static class WebMeth
    {
        // Returns an html code of the Url
        public static String code(string Url)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            return result;
        }

        // Returns a list of car Links from the front page of cars category
        public static string[] GetItemLinks(string category)
        {
            //string category = "https://www.list.am/category/23";
            string htmlCode;
            using (WebClient client = new WebClient())
                htmlCode = WebMeth.code(category);

            string itemPattern = @"(/item/\d+)";
            MatchCollection matches = Regex.Matches(htmlCode, itemPattern);
            string[] cars = new string[matches.Count - 1];
            for (int i = 0; i < cars.Length; i++)
            {
                GroupCollection data = matches[i].Groups;
                cars[i] = "https://www.list.am" + data[1].ToString();
            }
            return cars;
        }

        // From home URL, finds the category path of any category and returns its URL
        public static string GetCategoryLink(string url, string cat)
        {
            string htmlText = code(url);
            string pattern = "(/category/\\d+)\">" + cat + "<";
            MatchCollection matches = Regex.Matches(htmlText, pattern);
            GroupCollection data = matches[0].Groups;

            return url+data[1].ToString();
        }

        // Returns an array of names and URL-s of all of the categories in the website with given url
        public static string[][] GetCategories(string url)
        {
            string htmlText = code(url);
            string pattern = "href=\"(/category/\\d+)\">([^<]+)<";
            MatchCollection matches = Regex.Matches(htmlText, pattern);
            string[][] cats = new string[matches.Count][];
            for (int i = 0; i < cats.Length; i++)
            {
                cats[i] = new string[2];
                GroupCollection data = matches[i].Groups;
                cats[i][0] = data[2].ToString();
                cats[i][1] = url + data[1].ToString();
            }

            return cats;
        }
    }
}
