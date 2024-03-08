using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using School;

namespace School.xUnit.UnitTests.Factories
{
    public class CourseFactory
    {
        public static Course CreatePopulatedCourse(int numberOfStudents = 30, string defaultStudentName = "Aneliya")
        {
            Fixture fixture = new Fixture();
            Course course = new Course();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentName = defaultStudentName + fixture.Create<string>();
                course.JoinCourse(new Student(studentName, 10000 + i));
            }

            return course;
        }
    }
}
