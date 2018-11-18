using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    abstract class Animal : IOuterActions, IInnerAction
    {
        public String Name { get; set; }
        public abstract void Eat();
        public abstract void MakeSound();

        public void Move()
        {
            Console.WriteLine("Moving from point A to point B");
        }

        public virtual void Breathe()
        {
            Console.WriteLine("Breathing with lungs");
        }
    }
}
