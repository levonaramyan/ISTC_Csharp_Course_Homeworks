using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Planets
{
    class SpaceObject
    {
        public SpaceObject() { }

        public SpaceObject(string nm)
        {
            Name = nm;
        }

        public SpaceObject(string nm, double ms)
        {
            Name = nm;
            Mass = ms
        }
        public string Name { get; set; }
        public double Mass { get; set; }
        public int Age { get; set; }
        private readonly double g = 6.674 * Math.Pow(10, -11);

        // Getting gravitational acceleration for a given distance from the star
        public double GetGravAccel(double objDist)
        {
            return g * Mass * 1 / (objDist * objDist);
        }
    }
}
