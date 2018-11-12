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
        public static string[] GetCarLinks()
        {
            string category = "https://www.list.am/category/23";
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
    }
}
