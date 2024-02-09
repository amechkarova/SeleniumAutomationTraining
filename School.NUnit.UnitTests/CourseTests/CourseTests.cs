using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using School.NUnit.UnitTests.Factories;

namespace School.NUnit.UnitTests.CourseTests
{
    [TestFixture]
    public class CourseTests
    {
        [Test]
        public void ThrowException_When_31stStudentJoins()
        {
            //Arrange
            Course course = CourseFactory.CreatePopulatedCourse();

            //Act + Assert
            Assert.Throws<ArgumentException>(() => course.JoinCourse(new Student("Aneliya31", 10031)));
        }
    }
}
