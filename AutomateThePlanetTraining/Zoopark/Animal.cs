using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateThePlanetTraining.Zoopark
{
    internal abstract class Animal
    {
        protected Animal(string name, int age, bool isFemale) 
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name can't be empty");
            }
            if(age == null || age <= 0)
            {
                throw new ArgumentNullException("Invalid input");
            }

            Name = name;
            Age = age;
            IsFemale = isFemale;
        }

        public string Name { get; set; }
        public int Age {  get; set; }
        public bool IsFemale { get; set; }
        public abstract string AnimalSound { get; }

        public void ProduceSound()
        {
            Console.WriteLine(AnimalSound);
        }

        public override string ToString()
        {
            return $"Name:{Name}{ Environment.NewLine}, Age: {Age}{ Environment.NewLine}, isFemale: {IsFemale}{Environment.NewLine}, Produce sound: {AnimalSound}";
        }
    }
}
