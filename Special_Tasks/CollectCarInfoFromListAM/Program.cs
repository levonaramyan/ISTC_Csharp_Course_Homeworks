using System;
using System.Net;

namespace FirstProject
{

    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.WriteAllText(@"C:/Users/Aramyan/Desktop/CarsList.txt", ""); // Reseting the file of output
            string test1;
            string[] carLinks = WebMeth.GetCarLinks(); // The list of links of cars
            Model[] cars = new Model[carLinks.Length];
            for (int i = 0; i < carLinks.Length; i++)
            {
                using (WebClient client = new WebClient())
                    test1 = WebMeth.code(carLinks[i]); // getting an html code of current car

                Model car = GetInfo.GetFullModel(test1); // filling the necessary info
                car.Link = carLinks[i]; // adding the link
                string carInfo = car.Brand + " " + car.Type + " " + car.Year + " " + car.Color + " \n" + car.Price + " " + car.Link + " \n";
                System.IO.File.AppendAllText(@"C:/Users/Aramyan/Desktop/CarsList.txt", carInfo); // adding the info to a file
                Console.WriteLine(carInfo);
            }

            Console.ReadKey();
        }
    }
}
