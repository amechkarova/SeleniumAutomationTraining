using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace School.xUnit.UnitTests.StudentTests
{
    public class StudentTests
    {
        [Fact]
        public void ThrowArgumentException_When_NameIsEmpty()
        {
            Action action = () => new Student("", 10000);
            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void ThrowArgumentException_When_NameIsNull()
        {
            Action action = () => new Student(null, 10000);
            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void ThrowArgumentException_When_IdIsSmallerThan10000()
        {
            Action action = () => new Student("Aneliya", 9999);
            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void ThrowArgumentException_When_IdIsBiggerThan99999()
        {
            Action action = () => new Student("Aneliya", 100000);
            action.Should().Throw<ArgumentException>();

        }

        [Fact]
        public void NoThrowArgumentException_When_IdIs99999()
        {
            Action action = () => new Student("Aneliya", 99999);
            action.Should().NotThrow<ArgumentException>();
        }

        [Fact]
        public void NoThrowArgumentException_When_IdIs10000()
        {
            Action action = () => new Student("Aneliya", 10000);
            action.Should().NotThrow<ArgumentException>(); ;
        }
    }
}
