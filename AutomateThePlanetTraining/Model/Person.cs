using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateThePlanetTraining.Model
{
    internal class Person : IComparable<Person>, IEquatable<Person>
    {
        public Person(string name, int age)
        {
            if (age < 0) throw new ArgumentNullException("Age should be greater than 0.");
            Name = name;
            Age = age;
            UniqueID = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }
        public virtual int Age { get; set; }
        public string UniqueID { get; set; }


        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, ID: {2}", Name, Age, UniqueID);
        }

        public bool Equals(Person other)
        {
            return UniqueID == other.UniqueID;
        }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
        }
    }
}
