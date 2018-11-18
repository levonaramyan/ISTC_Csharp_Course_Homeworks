using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    class Rabbit : Herbivore
    {
        public Rabbit()
        {
            Name = "Rabbit";
        }

        public string PreferedFood { get; } = "Carrot";
        public override void MakeSound()
        {
            Console.WriteLine("u-u-u-u-ui-ui-ui-u-u!!!");
        }
    }
}
