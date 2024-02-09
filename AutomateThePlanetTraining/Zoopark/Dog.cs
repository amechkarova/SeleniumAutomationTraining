using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateThePlanetTraining.Zoopark
{
    internal class Dog : Animal
    {
        public Dog(string name, int age, bool isFemale)
            : base(name, age, isFemale)
        {

        }
        public override string AnimalSound => "Waf Waf";
    }
}
