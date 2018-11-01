using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Planets
{
    class Star
    {
        public Star()
        {
            GalacticCoordinates = new double[2];
            ZoneOfHabitability = new double[2];
            Planets = new Planet[0];
        }

        public string Name { get; set; }
        public double[] GalacticCoordinates { get; set; }
        public double TempOfSurface { get; set; }
        public double Radius { get; set; }
        public double Mass { get; set; }
        public string SpectralClass { get; set; }
        public double[] ZoneOfHabitability { get; set; }
        public Planet[] Planets { get; set; }
        
        public int Age { get; set; }
        private double g = 6.674 * Math.Pow(10, (-11));

        // Increases the temperature of a star and subtracts from the Mass, a mass of ejecta
        public void Eruption(int strength)
        {
            if (strength < 10)
            {
                TempOfSurface *= strength / 1000;
                Mass *= strength * strength / 1_000_000;
            }
        }

        // Getting gravitational acceleration for a given distance from the star
        public double GetGravAccel(double objDist)
        {
            return g * Mass * 1 / (objDist * objDist);
        }

        // Adding a Planet p in Planets[]
        public void AddPlanet(Planet pl)
        {
            int num = Planets.Length;
            Planet[] newList = new Planet[num + 1];
            for (int i = 0; i < num; i++)
                newList[i] = Planets[i];
            newList[num] = pl;
            Planets = newList;
        }
    }
}
