using FluentAssertions;
using School.xUnit.UnitTests.Factories;

namespace School.xUnit.UnitTests.CourseTests
{
    public class CourseTests
    {
        [Fact]
        public void ThrowException_When_31stStudentJoins()
        {
            //Arrange
            Course course = CourseFactory.CreatePopulatedCourse();

            //Act + Assert
            Action action = () => course.JoinCourse(new Student("Aneliya31", 10031));
            action.Should().Throw<ArgumentException>();
        }
    }
}