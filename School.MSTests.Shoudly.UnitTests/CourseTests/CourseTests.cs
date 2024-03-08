using Shouldly;
namespace School.MSTests.Shoudly.UnitTests.CourseTests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void ThrowException_When_31stStudentJoins()
        {
            //Arrange
            Course course = CourseFactory.CreatePopulatedCourse();

            //Act + Assert
            Should.Throw<ArgumentException>(() => course.JoinCourse(new Student("Aneliya31", 10031)));
        }
    }
}