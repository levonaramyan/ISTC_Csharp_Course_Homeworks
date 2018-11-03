using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Planets
{
    class Planet : SpaceObject
    {
        public Planet() { }

        public Planet(string nm): base(nm) { }

        public Planet(string nm, double ms): base(nm,ms) { }

        public double DistFromStar { get; set; }
        public double OrbitExcentricity { get; set; }
        public double YearLength { get; set; }
        public double DayLength { get; set; }
        public double Radius { get; set; }
        public int NumberOfMoons { get; set; }
        public double AxisTilt { get; set; }
        public double AxialRotation { get; set; }
        public double OrbitalAzymuth { get; set; }
        public ChemicalComposition ChemComp { get; set; }
        private readonly double pi = Math.PI;
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
