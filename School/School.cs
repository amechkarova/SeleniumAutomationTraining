using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private List<Student> _students;
        private int currentId;

        public School() 
        { 
            _students = new List<Student>();
            currentId = 10000;
        }

        public void AddStudent(string name)
        {
            if(_students.Any(x=>x.Name.Equals(name)))
            {
                throw new ArgumentException($"Student with name = {name} already exists.");
            }

            Student student = new Student(name, currentId++);
            _students.Add(student);
        }
    }
}
