using CollectCarInfoFromListAM;
using System;
using System.Net;

namespace FirstProject
{

    class Program
    {
        static void Main(string[] args)
        {
            string website = "https://www.list.am/";
            CategoryData cars = new CategoryData();
            cars.Category = "Ավտոմեքենաներ";
            string catLink = WebMeth.GetCategoryLink(website, cars.Category);
            //string[][] cats = WebMeth.GetCategories(website);
            //System.IO.File.WriteAllText(@"C:/Users/Aramyan/Desktop/CategList.txt", ""); // Reseting the file of output
            //foreach (string[] cat in cats)
            //    System.IO.File.AppendAllText(@"C:/Users/Aramyan/Desktop/CategList.txt",
            //        $"{cat[0]} - {cat[1]} " + Environment.NewLine); // The list of category names and their links

            string output = @"C:/Users/Aramyan/Desktop/CarsList.txt"; // The directory of output file
            System.IO.File.WriteAllText(output, ""); // Reseting the file of output
            string tempHTML;
            string[] carLinks = WebMeth.GetItemLinks(catLink); // The list of links of cars
            cars.Items = new Item[carLinks.Length];

            // Collecting data from the webpages of each item
            for (int i = 0; i < carLinks.Length; i++)
            {
                cars.Items[i] = new Item();
                cars.Items[i].Url = carLinks[i];
                using (WebClient client = new WebClient())
                    tempHTML = WebMeth.Code(carLinks[i]); // getting an html code of current car
            
                cars.Items[i].Title = GetInfo.GetTitle(tempHTML);
                cars.Items[i].Body = GetInfo.GetBody(tempHTML);
                cars.Items[i].Price = GetInfo.GetPrice(tempHTML);
                cars.Items[i].Parameters = GetInfo.GetParam(tempHTML);
            }

            // Printing the information in *.txt files
            foreach (Item car in cars.Items)
            {
                var nl = Environment.NewLine + Environment.NewLine;
                string par = "";
                string separation = new string('*', 100);
                for (int i = 0; i < car.Parameters.Length; i++)
                    par += $"{car.Parameters[i][0]} - {car.Parameters[i][1]}" + " || ";

                System.IO.File.AppendAllText(output, car.Title + " || " + car.Url + nl +
                    car.Price + nl + par + nl + car.Body + nl + separation + nl);
            }

            Console.ReadKey();
        }
    }
}
