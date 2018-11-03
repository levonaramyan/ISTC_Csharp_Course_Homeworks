using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Planets
{
    class ChemicalComposition
    {
        public double Helium { get; set; }
        public double Hydrogen { get; set; }
        public double Oxygen { get; set; }
        public double Nytrogen { get; set; }
        public double Carbon { get; set; }
        public double CarbonDioxide { get; set; }
        public double Methane { get; set; }
        public double Water { get; set; }
        public double Ozone { get; set; }
        public double Iron { get; set; }
        public double Magnesium { get; set; }
        public double Silicon { get; set; }
        public double Sulfur { get; set; }
        public double Nickel { get; set; }
        public double Others { get; set; }

        public double TotalWeight()
        {
            double sum = Helium + Hydrogen + Oxygen + Nytrogen + Carbon + CarbonDioxide + Methane +
                Water + Ozone + Iron + Magnesium + Silicon + Sulfur + Nickel + Others;

            return sum;
        }

    }
}
