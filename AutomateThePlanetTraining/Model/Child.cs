using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateThePlanetTraining.Model
{
    internal class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
        }
        public override int Age
        {
            get => base.Age;
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("The children should be below 15.");
                }
                base.Age = value;
            }
        }

    }
}
