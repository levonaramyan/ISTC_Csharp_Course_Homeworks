using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new instance of Class Planet and initializing some fields
            Planet earth = new Planet("Earth");
            earth.Mass = 5.972 * Math.Pow(10, 24);
            earth.DistFromStar = 1.496 * Math.Pow(10, 11);
            earth.Radius = 6371 * 1000;
            earth.OrbitalAzymuth = 0;

            // Creating a new instance of Class Star and initializing some fields
            double massOfSun = 1.989 * Math.Pow(10, 30);
            Star sun = new Star("Sun",massOfSun);

            // Creating few more instance of Class Planet and initializing their fields Name
            Planet mercury = new Planet("Mercury");
            Planet venus = new Planet("Venus");
            Planet mars = new Planet("Mars");

            // Adding a sun as HostStar for all of the planets
            earth.HostStar = sun;
            mercury.HostStar = sun;
            venus.HostStar = sun;
            mars.HostStar = sun;

            // Getting the gravitational acceleration of Earth to the Sun and the one in the surface of Earth
            double earthsAccelToSun = sun.GetGravAccel(earth.DistFromStar);
            double gravityInEarth = earth.GetGravAccel(earth.Radius);

            // Printing all of the planets of earth
            Console.WriteLine($"The planets of {sun.Name} are:");
            foreach (Planet p in sun.Planets) Console.WriteLine(p.Name);
            Console.WriteLine();

            // Printing the acceleration of earth in Sun's Orbit
            Console.WriteLine($"The {earth.Name}'s acceleration to the {sun.Name} is:");
            Console.WriteLine(Math.Round(earthsAccelToSun, 3)+"\n");

            // The acceleration g on the surface of Earth
            Console.WriteLine($"The gravitational acceleration g in the surface of {earth.Name} is:");
            Console.WriteLine(Math.Round(gravityInEarth,3)+"\n");

            // Printing the seasons of correponding months in Earth, starting from initialized date
            Console.WriteLine($"Now let's see the changes of the season in planet {earth.Name}:");
            Console.WriteLine("Press any key to see...");
            Console.ReadKey();
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Month {i+1}: {earth.GetCurrentSeason()}");
                earth.Orbit(Math.PI / 6);
            }
            Console.ReadKey();

        }
    }
}
