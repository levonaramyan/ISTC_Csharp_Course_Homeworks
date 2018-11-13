using System;
using System.Net;

namespace FirstProject
{

    class Program
    {
        static void Main(string[] args)
        {
            string website = "https://www.list.am/";
            string category = "Ավտոմեքենաներ";
            string catLink = WebMeth.GetCategoryLink(website, category);
            string[][] cats = WebMeth.GetCategories(website);
            System.IO.File.WriteAllText(@"C:/Users/Aramyan/Desktop/CategList.txt", ""); // Reseting the file of output
            foreach (string[] cat in cats)
                System.IO.File.AppendAllText(@"C:/Users/Aramyan/Desktop/CategList.txt",
                    $"{cat[0]} - {cat[1]} " + Environment.NewLine); // The list of category names and their links

            System.IO.File.WriteAllText(@"C:/Users/Aramyan/Desktop/CarsList.txt", ""); // Reseting the file of output
            string test1;
            string[] carLinks = WebMeth.GetItemLinks(catLink); // The list of links of cars
            Model[] cars = new Model[carLinks.Length];
            for (int i = 0; i < carLinks.Length; i++)
            {
                using (WebClient client = new WebClient())
                    test1 = WebMeth.code(carLinks[i]); // getting an html code of current car

                Model car = GetInfo.GetFullModel(test1); // filling the necessary info
                car.Link = carLinks[i]; // adding the link
                string carInfo = car.Brand + " " + car.Type + " " + car.Year + " " + car.Color + " \n" + car.Price + " " + car.Link + "\n";
                System.IO.File.AppendAllText(@"C:/Users/Aramyan/Desktop/CarsList.txt", carInfo + Environment.NewLine); // adding the info to a file
                Console.WriteLine(carInfo);
            }

            Console.ReadKey();
        }
    }
}
