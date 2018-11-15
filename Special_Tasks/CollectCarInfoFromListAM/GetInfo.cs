using System;
using System.Text.RegularExpressions;

namespace FirstProject
{
    static class GetInfo
    {
        // Returns the price, or -1, if no price is available
        public static string GetPrice(string s)
        {
            string pattern = "\"price\">([^<]+)<";
            MatchCollection matches = Regex.Matches(s, pattern);
            if (matches.Count < 1) return "-1";
            GroupCollection data = matches[0].Groups;
            return data[1].ToString();
        }

        // Returns the title of an item
        public static string GetTitle(string s)
        {
            string pattern = "<h1>([^<]*)</h1>";
            MatchCollection matches = Regex.Matches(s, pattern);
            if (matches.Count < 1) return "N/A";
            GroupCollection data = matches[0].Groups;
            return data[1].ToString();
        }

        // Returns the body description of an item
        public static string GetBody(string s)
        {
            s = s.Replace("<br>", "\n");
            string pattern = "\"body\">([^<]*)</div>";
            MatchCollection matches = Regex.Matches(s, pattern);
            if (matches.Count < 1) return "N/A";
            GroupCollection data = matches[0].Groups;
            return data[1].ToString();
        }

        // Returns items any parameter from html code
        public static string GetParam(string s, string param)
        {
            string pattern = param + "<[^>]*><[^>]*>([^<]*)<";
            MatchCollection matches = Regex.Matches(s, pattern);
            if (matches.Count < 1) return "N/A";
            GroupCollection data = matches[0].Groups;
            return data[1].ToString();
        }

        // Returns all the item parameters that exists in html code
        public static string[][] GetParam(string s)
        {
            string pattern = "\"t\">([^<]*)</div><[^\"]*\"i\">([^<]*)(</div>|<sup>2</sup></div>)";
            MatchCollection matches = Regex.Matches(s, pattern);
            string[][] res = new string[matches.Count][];
            for (int i = 0; i < matches.Count; i++)
            {
                GroupCollection data = matches[i].Groups;
                res[i] = new string[] {data[1].ToString(),data[2].ToString() };
            }
            return res;
        }

        // Returns a car with full info
        public static Car GetFullModel(string s)
        {
            Car car = new Car();
            car.Brand = GetParam(s, "Տեսակ");//car.Brand = GetBrand(s);
            car.Color = GetParam(s, "Գույն");//car.Color = GetColor(s);
            car.Price = GetPrice(s);
            car.Type = GetParam(s, "Մոդել");//car.Type = GetModel(s);
            car.Year = GetParam(s, "Տարի");//car.Year = GetYear(s);
            car.Body = GetBody(s);
            car.Title = GetTitle(s);
            return car;
        }
    }
}
