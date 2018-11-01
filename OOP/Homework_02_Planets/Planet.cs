using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Planets
{
    class Planet
    {
        public string Name { get; set; }
        public double DistFromStar { get; set; }
        public double OrbitExcentricity { get; set; }
        public double YearLength { get; set; }
        public double DayLength { get; set; }
        public double Mass { get; set; }
        public double Radius { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public bool IsRocky { get; set; }
        public bool HasWater { get; set; }
        public bool HasAtmosphere { get; set; }
        public int NumberOfMoons { get; set; }
        public double AxisTilt { get; set; }
        public double AxialRotation { get; set; }
        public double OrbitalAzymuth { get; set; }
        private double g = 6.674 * Math.Pow(10, (-11));
        private double pi = Math.PI;
        private Star hostStar;
        public Star HostStar
        {
            get { return hostStar; }
            set { hostStar = value; hostStar.AddPlanet(this); } // Adding also the planet in Planets[] of HostStar
        }

        // Rotates the planet around its axis
        public void Rotate(double rot)
        {
            AxialRotation = (AxialRotation + rot) % (2 * pi);
        }

        // Planet is orbiting around its HostStar
        public void Orbit(double rot)
        {
            OrbitalAzymuth = (OrbitalAzymuth + rot) % (2*pi);
        }

        // Returns the gravitational acceleration in a given distance from the planet
        public double GetGravAccel(double objDist)
        {
            return g * Mass * 1 / (objDist * objDist);
        }

        // Returns the current season on the planet
        public string GetCurrentSeason()
        {
            if (OrbitalAzymuth >= pi * 7 / 4 || OrbitalAzymuth < pi / 4) return "winter";
            else if (OrbitalAzymuth >= pi / 4 && OrbitalAzymuth < pi * 3 / 4) return "spring";
            else if (OrbitalAzymuth >= pi * 3 / 4 && OrbitalAzymuth < pi * 5 / 4) return "summer";
            else return "autumn";
        }
    }
}
