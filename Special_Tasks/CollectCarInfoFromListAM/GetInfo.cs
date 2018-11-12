using System;
using System.Text.RegularExpressions;

namespace FirstProject
{
    static class GetInfo
    {
        private static string GetPrice(string s)
        {
            string pattern = "\"price\">([^<]+)<";
            MatchCollection matches = Regex.Matches(s, pattern);
            if (matches.Count < 1) return "-1";
            GroupCollection data = matches[0].Groups;
            return data[1].ToString();
        }

        private static string GetYear(string s)
        {
            string pattern = @"Տարի[^\d]+(\d{4})<";
            MatchCollection matches = Regex.Matches(s, pattern);
            GroupCollection data = matches[0].Groups;
            return data[1].ToString();
        }

        private static string GetBrand(string s)
        {
            string pattern = "Տեսակ<[^>]*><[^>]*>([^<]*)<";
            MatchCollection matches = Regex.Matches(s, pattern);
            GroupCollection data = matches[0].Groups;
            return data[1].ToString();
        }

        private static string GetModel(string s)
        {
            string pattern = "Մոդել<[^>]*><[^>]*>([^<]*)<";
            MatchCollection matches = Regex.Matches(s, pattern);
            GroupCollection data = matches[0].Groups;
            return data[1].ToString();
        }

        private static string GetColor(string s)
        {
            string pattern = "Գույն<[^>]*><[^>]*>([^<]*)<";
            MatchCollection matches = Regex.Matches(s, pattern);
            if (matches.Count < 1) return "Unspecified";
            GroupCollection data = matches[0].Groups;
            return data[1].ToString();
        }

        public static Model GetFullModel(string s)
        {
            Model car = new Model();
            car.Brand = GetInfo.GetBrand(s);
            car.Color = GetInfo.GetColor(s);
            car.Price = GetInfo.GetPrice(s);
            car.Type = GetInfo.GetModel(s);
            car.Year = GetInfo.GetYear(s);
            return car;
        }
    }
}
