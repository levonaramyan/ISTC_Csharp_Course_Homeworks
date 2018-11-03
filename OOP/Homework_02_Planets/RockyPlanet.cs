using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Planets
{
    class RockyPlanet : Planet
    {
        public RockyPlanet()
        {
        }

        public RockyPlanet(string nm) : base(nm)
        {
        }

        public RockyPlanet(string nm, double ms) : base(nm, ms)
        {
        }
        
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public bool HasWater { get; set; }
        public bool HasAtmosphere { get; set; }

    }
}
