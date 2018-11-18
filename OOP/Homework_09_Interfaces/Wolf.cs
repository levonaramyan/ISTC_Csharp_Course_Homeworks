using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    class Wolf : Carnivore
    {
        public Wolf()
        {
            Name = "Wolf";
        }

        public string AfraidsOf { get; } = "Fire";

        public override void MakeSound()
        {
            Console.WriteLine("Auuuuuuuu!!!");
        }
    }
}
