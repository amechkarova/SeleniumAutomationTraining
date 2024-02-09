using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void ThrowException_When_31stStudentJoins()
        {
            //Arrange
            Course course = new Course();
            for (int i = 0; i <  30; i++)
            {
                course.JoinCourse(new Student($"Aneliya{i}", 10000 + i));
            }

            //Act + Assert
            Assert.ThrowsException<ArgumentException>(() => course.JoinCourse(new Student("Aneliya31", 10031)));
        }
    }
}
