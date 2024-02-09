using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private List<Student> _students = new List<Student>();

        public void JoinCourse(Student student)
        {
            if(_students.Count >= 30)
            {
                throw new ArgumentException("Course is full.");
            }
            _students.Add(student);
        }

        public void LeaveCourse(string name) 
        {
            if(!_students.Any(x=>x.Name.Equals(name))) 
            {
                throw new ArgumentException($"Student with name = {name} cannot be found.");
            }
            _students.Remove(_students.First(x => x.Name.Equals(name)));
        }
    }
}
