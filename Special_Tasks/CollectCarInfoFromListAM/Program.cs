using System;
using System.Net;

namespace FirstProject
{

    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.WriteAllText(@"C:/Users/Aramyan/Desktop/CarsList.txt", "");
            string test1;
            string[] carLinks = WebMeth.GetCarLinks();
            Model[] cars = new Model[carLinks.Length];
            for (int i = 0; i < carLinks.Length; i++)
            {
                using (WebClient client = new WebClient())
                    test1 = WebMeth.code(carLinks[i]);
                Model car = GetInfo.GetFullModel(test1);
                car.Link = carLinks[i];
                string carInfo = car.Brand + " " + car.Type + " " + car.Year + " " + car.Color + " \n" + car.Price + " " + car.Link + " \n";
                System.IO.File.AppendAllText(@"C:/Users/Aramyan/Desktop/CarsList.txt", carInfo);
                Console.WriteLine(carInfo);
            }

            Console.ReadKey();
        }
    }
}
