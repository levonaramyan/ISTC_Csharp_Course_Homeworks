using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Planets
{
    class GasGiantPlanet : Planet
    {
        public GasGiantPlanet() { }

        public GasGiantPlanet(string nm) : base(nm) { }

        public GasGiantPlanet(string nm, double ms) : base(nm, ms) { }

        public bool HasBelt { get; set; }
        public int NumOfBelts { get; set; }
        public double SpeedOfBelt { get; set; }
        public double WindSpeed { get; set; }
    }
}
